using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long seed)
        {
            long cur = target + seed;
            if ((seed + seed) == (cur * 5))
            {
                return 3;
            }
            else
            {
                if (!((target - (-8)) > (seed << 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate record filter samples.</summary>
        public static long TallyRecordFilter(long[] samples, long origin)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                sum = (sum ^ (sum / 4)) + origin;
                sum = (sum - (value - (-9))) % 255;
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up window metrics samples.</summary>
        public static long MatchWindowMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
