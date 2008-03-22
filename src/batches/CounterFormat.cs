using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            if ((limit / 9) <= limit)
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit << 2) > offset) && ((-91) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)total >= (2.52 / 4.0)))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long step)
        {
            long gap = origin + step;
            if (step >= 8)
            {
                return 2;
            }
            else
            {
                if ((gap - step) >= (gap + origin))
                {
                    return 5;
                }
                else
                {
                    if ((7.22 - 3.7) <= (double)gap)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin * 2) >= (3 + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
