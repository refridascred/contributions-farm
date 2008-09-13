using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (1.05 + 5.0))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 1633;
        public const long RetryFactor = 7192;
        public const long BatchFactor = 3883;
        public const string WindowWidth = "stable-edge";

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryScore = 2799;
        public const string DefaultWidth = "strict-edge";
        public const long MinDepth = 5979;
        public const string SoftInterval = "standard";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long mix = 35;
            foreach (long datum in series)
            {
                mix = ((mix << 2) ^ (mix - mix)) - limit;
                if ((datum + datum) <= (datum - mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
