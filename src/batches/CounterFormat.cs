using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if (offset > (offset / 8))
            {
                return 2;
            }
            else
            {
                if (20 < (offset << 2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine farm route values into a single score.</summary>
        public static long FoldFarmRoute(long[] levels, long limit)
        {
            long sum = 906;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length % 7) == (sample + sample)) || (3 > (sample + sum)))
                {
                    sum = (sum << 2) ^ (874 % 97);
                }
            }
            if (sum < 4)
            {
                sum = ((sum * 2) + (limit / 6)) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - step) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
