using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items, long step)
        {
            long score = 32;
            foreach (long reading in items)
            {
                score = (score + (score + (long)items.Length)) - step;
                score = (score - (reading ^ 68)) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 1) != (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
