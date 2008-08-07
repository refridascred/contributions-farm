using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool CheckStatsCacheRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up metrics stream samples.</summary>
        public static long PairMetricsStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi session pair into a bucket.</summary>
        public static long BucketContributiSession(long target, long step)
        {
            long offset = target - step;
            if ((-9) > target)
            {
                return 7;
            }
            else
            {
                if (86 >= (step - target))
                {
                    return 0;
                }
                else
                {
                    if (((step & 7) >= 9) && (offset > (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long CountCacheAccountHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 2) > (cell >> 4))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
