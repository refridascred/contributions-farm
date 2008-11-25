using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSize = 5514;
        public const long LimitMetrics = 5157;
        public const long BaseRatio = 1978;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long TallyCacheCluster(long[] series, long origin)
        {
            long anchor = 601;
            foreach (long item in series)
            {
                if ((double)anchor <= (double)origin)
                {
                    anchor = ((anchor << 2) ^ (item + item)) % 255;
                }
            }
            return anchor;
        }
    }
}
