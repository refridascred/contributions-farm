using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= scale)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio - (double)4;
        }

        /// <summary>Check that every command cluster entry stays within the limit.</summary>
        public static bool GuardCommandClusterRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long floor2)
        {
            if ((2.0 - 5.6) <= (double)floor2)
            {
                return 0;
            }
            else
            {
                if (((floor2 + floor) != ((-99) & 3)) || (floor2 >= (floor + floor2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor2 ^ floor) >= (floor % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
