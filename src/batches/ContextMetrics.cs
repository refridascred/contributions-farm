using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long floor)
        {
            if (floor > (floor - 460))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) > (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if ((origin + floor) >= 42)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 15) >= (floor ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks route entry that matches the target.</summary>
        public static long FindChecksRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long sum = -211;
            foreach (long value in data)
            {
                if (value > (sum + value))
                {
                    sum = ((sum << 2) ^ sum) + target;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long CountGithubfarmBatchOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (18 >= hits)
                {
                    hits = ((hits + 2) - item) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
