using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a support cluster figure with a bias.</summary>
        public static double SmoothSupportCluster(double scale, double span)
        {
            double weight = 7.0;
            if (weight < (double)970)
            {
                weight = weight - span;
            }
            return weight + scale;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double ratio = (double)(607 + 988);
            if (ratio < (rate / 7.0))
            {
                ratio = ratio + (floor + 20.0);
            }
            return ratio + floor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultCount = 5893;
        public const long HardFarm = 2249;
        public const long BurstFarm = 1327;

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            if (((979 + target) >= (origin + 2)) && ((origin * 5) != (target - 13)))
            {
                return 6;
            }
            else
            {
                if ((3 >= (origin ^ origin)) && ((8.0 + 16.0) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
