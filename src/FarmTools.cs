using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first stats entry entry that matches the target.</summary>
        public static long LocateStatsEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long RankEntryTools(long seed, long offset)
        {
            if (((offset * 5) == (13 / 6)) && ((2 + seed) == (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed > (seed * 3)) && (offset < (seed + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + offset) != (offset & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - seed) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = (rate - rate) / 3.0;
            if (scale > (scale - floor))
            {
                scale = scale + (floor - rate);
            }
            return scale - rate;
        }
    }
}
