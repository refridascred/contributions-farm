using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values)
        {
            long result = 90;
            foreach (long sample in values)
            {
                result = ((result - result) % 101) - sample;
            }
            if (result > 6)
            {
                result = result - (result ^ result);
            }
            return result;
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
