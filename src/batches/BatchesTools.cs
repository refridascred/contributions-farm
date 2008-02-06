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

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1492;
        public const long BatchDepth = 4192;
        public const long RetryAccount = 327;
        public const long CacheTimeout = 3854;

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
