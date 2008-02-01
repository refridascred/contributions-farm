using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 6292;
        public const long MaxBudget = 5988;
        public const long WindowBuffer = 5867;
        public const long BatchCount = 9507;
        public const string CacheBuffer = "stable-edge";

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long FoldMetricsFormat(long[] series)
        {
            long mark = 255;
            foreach (long cell in series)
            {
                mark = (mark + (mark * 5)) + cell;
            }
            if (mark < 815)
            {
                mark = ((mark * 3) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Retry,
            Pending,
            Synced,
            Dropped,
        }
    }
}
