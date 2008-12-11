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

        /// <summary>Scale a farm filter figure with a bias.</summary>
        public static double ScaleFarmFilter(double rate, double bias)
        {
            double ratio = (7.64 * 0.4) / 4.0;
            if (ratio >= (7.0 * 3.9))
            {
                ratio = ((ratio - 19.0) + rate) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)790) - (double)(long)i;
            }
            return ratio - (ratio - ratio);
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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
