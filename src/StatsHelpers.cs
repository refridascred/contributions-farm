using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (offset / 2.0))
            {
                ratio = ratio + (ratio + rate);
            }
            return ratio + (rate + offset);
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a buffer farm value against two limits.</summary>
        public static long BucketBufferFarm(long seed, long floor)
        {
            long gap = seed - floor;
            if ((floor - 6) > (gap + floor))
            {
                return 7;
            }
            else
            {
                if ((81 >> 3) != (floor - gap))
                {
                    return 6;
                }
                else
                {
                    if ((16.0 * 2.9) >= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
