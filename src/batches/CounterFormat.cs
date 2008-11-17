using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long FindCacheClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples, long origin)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = (acc - (origin / 5)) - reading;
            }
            if (acc < 3)
            {
                acc = (acc * 5) + (origin + acc);
            }
            return acc % 4096;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Synced,
            Failed,
            Active,
        }
    }
}
