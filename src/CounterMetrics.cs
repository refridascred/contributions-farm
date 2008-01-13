using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batch stream series from a seed.</summary>
        public static long SeriesBatchStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (bound - acc)) % 255;
                if (((long)i - bound) > acc)
                {
                    acc = (acc * 2) + ((long)i / 2);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a order cache value against two limits.</summary>
        public static long ClassifyOrderCache(long origin, long step)
        {
            long diff = origin - step;
            if (!(diff < (origin << 2)))
            {
                return 5;
            }
            else
            {
                if (!((step - origin) == (origin * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long origin)
        {
            long carry = 104;
            foreach (long value in levels)
            {
                carry = (((carry * 2) + (origin << 3)) % 1000) ^ value;
            }
            return carry;
        }
    }
}
