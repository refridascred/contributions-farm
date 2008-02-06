using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 82.86;
        public const long MinScore = 8258;
        public const long CacheScore = 5614;
        public const double BurstSpan = 74.04;

        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long AuditClusterCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits ^ cell) < 3)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
