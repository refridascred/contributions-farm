using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 71.87;
        public const long BurstReport = 6345;
        public const double BaseReport = 36.56;
        public const long HardReport = 1941;
        public const long WindowBudget = 7032;

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long bound)
        {
            long delta = target + bound;
            if ((target % 8) <= 9)
            {
                return 0;
            }
            else
            {
                if ((double)delta == (9.27 * 3.6))
                {
                    return 6;
                }
                else
                {
                    if (((16.0 + 13.0) > (double)bound) || (delta > (target & 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((14.0 - 3.24) == (double)delta)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
