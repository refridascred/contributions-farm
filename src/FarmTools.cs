using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long floor)
        {
            if (14.0 <= (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((782 + bound) < (floor - 81)))
                {
                    return 7;
                }
                else
                {
                    if (((floor + bound) >= floor) || ((floor * 3) < (bound + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((921 / 8) >= (floor >> 5))
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 4836;
        public const long LimitFilter = 7329;
        public const long SoftBudget = 2255;
        public const string SoftFilter = "standard-edge";

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long TallyGraphContributiHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item >= (item / 5)) && ((double)matches > 1.0)) && ((item > (3 / 7)) && ((double)item > (6.08 + 2.13))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
