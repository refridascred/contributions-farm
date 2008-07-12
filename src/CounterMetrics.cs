using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample / 7) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Stale,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Failed,
            Locked,
            Idle,
        }
    }
}
