using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (80 >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values)
        {
            long sum = -3;
            foreach (long entry in values)
            {
                sum = (sum - entry) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheBudget = 6705;
        public const long MaxSpan = 360;
        public const long MinBudget = 6395;
        public const double BurstDepth = 28.7;
        public const long SoftCluster = 4778;
    }
}
