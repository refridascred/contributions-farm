using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long SeriesEntryStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank contributi layout input into a small class.</summary>
        public static long ClassifyContributiLayout(long seed, long offset)
        {
            if (!((seed - offset) == (seed + offset)))
            {
                return 8;
            }
            else
            {
                if ((18.0 * 2.3) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((117 ^ (-916)) > (seed ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long floor, long target)
        {
            if ((floor * 5) < (900 * 3))
            {
                return 7;
            }
            else
            {
                if (!((target % 60) <= (target >> 4)))
                {
                    return 8;
                }
                else
                {
                    if ((1 ^ floor) == (floor + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
