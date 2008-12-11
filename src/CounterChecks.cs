using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Paused,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Check that every githubfarm cache entry stays within the limit.</summary>
        public static bool CheckGithubfarmCacheRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the token support series from a seed.</summary>
        public static long RollTokenSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (sum < ((long)i << 3))
                {
                    sum = sum ^ (3 + limit);
                }
                sum = (sum - (sum - (long)i)) % 4096;
                sum = (sum - (sum + limit)) % 4096;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long bound)
        {
            long gap = floor ^ bound;
            if (!((double)bound < (6.28 / 8.0)))
            {
                return 4;
            }
            else
            {
                if (((-8) * 2) > (bound - gap))
                {
                    return 1;
                }
                else
                {
                    if ((bound <= 586) && ((floor / 7) > gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long DigestStreamStats(long[] items, long seed)
        {
            long anchor = 44;
            foreach (long item in items)
            {
                if ((seed - anchor) < (anchor / 3))
                {
                    anchor = ((anchor * 3) + (anchor - seed)) - item;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
