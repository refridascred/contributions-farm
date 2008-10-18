using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 65.2;
        public const double CacheSize = 86.93;
        public const long RetryChecks = 7175;
        public const long CacheChecks = 8512;
        public const double LimitChecks = 89.85;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches * 2) <= matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Dropped,
            Synced,
        }
    }
}
