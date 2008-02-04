using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSpan = 3194;
        public const long CacheCounter = 2129;
        public const long IdleCount = 8413;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((2.0 * 19.0) != (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
