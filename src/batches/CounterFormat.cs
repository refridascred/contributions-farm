using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheTimeout = 96.96;
        public const long HardScore = 9902;
        public const long MaxRatio = 7640;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)value < (12.0 / 3.0)) || ((3.62 - 9.0) > (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
