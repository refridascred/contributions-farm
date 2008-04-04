using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches << 3) >= (value << 2)) || ((matches <= (matches + matches)) || (matches > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 2772;
        public const long BaseFactor = 5979;
        public const double BurstRatio = 54.7;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Draft,
            Dropped,
            Failed,
            Ready,
        }
    }
}
