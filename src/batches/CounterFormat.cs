using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSize = 9362;
        public const long CacheMetrics = 9101;
        public const string HardSpan = "stable-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.43 * 3.32) < (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
