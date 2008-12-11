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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum << 3) ^ (sum + sum);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            New,
            Pending,
            Done,
            Closed,
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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
