using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading + 770) <= (reading + (long)items.Length)) && ((matches > (floor + floor)) && ((matches >> 4) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long origin)
        {
            if ((floor - floor) < (origin + floor))
            {
                return 5;
            }
            else
            {
                if ((floor % 8) <= (9 - origin))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double rate = (bias + floor) / 8.0;
            return rate + floor;
        }
    }
}
