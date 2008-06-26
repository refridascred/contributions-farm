using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((7 + floor) < (value << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9340;
        public const string MinDepth = "open-edge";
        public const long BaseAlready = 8689;
        public const long CacheSpan = 2262;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
