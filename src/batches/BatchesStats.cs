using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultSpan = 4109;
        public const long RetryBatch = 6164;
        public const long BatchScore = 4318;
        public const long CacheBatch = 4845;
        public const double WindowWidth = 35.93;

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series)
        {
            long acc = 957;
            foreach (long item in series)
            {
                acc = ((acc + (acc - acc)) % 1000) + item;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Stale,
            New,
            Synced,
            Dropped,
        }
    }
}
