﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace System.IO.Pipelines
{
    public class StreamPipeReaderOptions
    {
        private const int DefaultBufferSize = 4096;
        private const int DefaultMinimumReadSize = 1024;

        internal static readonly StreamPipeReaderOptions s_default = new StreamPipeReaderOptions();

        public StreamPipeReaderOptions(MemoryPool<byte> pool = null, int bufferSize = DefaultBufferSize, int minimumReadSize = DefaultMinimumReadSize)
        {
            Pool = pool ?? MemoryPool<byte>.Shared;
            BufferSize = bufferSize;
            MinimumReadSize = minimumReadSize;
        }

        public int BufferSize { get; }
        public int MinimumReadSize { get; }
        public MemoryPool<byte> Pool { get; }
    }
}
