using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8233;
        public const long BurstWindow = 539;
        public const long RetryLevel = 826;
        public const long LimitTimeout = 7455;
        public const long IdleWidth = 6869;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long MeasureToolsStreamHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)9 < (double)origin) && !((double)hits != (7.69 - 16.0)))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
