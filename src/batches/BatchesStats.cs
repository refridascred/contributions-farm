using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long SeekEntryTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            New,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count >= (item >> 2)) && ((11.0 - 19.0) >= (double)item))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "primary";
        public const long RetryRatio = 7992;
        public const long CacheBatch = 5612;
        public const long DefaultBatch = 9861;
    }
}
