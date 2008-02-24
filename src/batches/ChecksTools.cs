using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double bias2 = bias - (double)980;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias + weight)) - (double)(long)i;
            }
            return bias2 + (double)69;
        }

        /// <summary>Grade a stats contributi value against two limits.</summary>
        public static long SortStatsContributi(long offset, long bound)
        {
            if ((2 - offset) <= (9 & 15))
            {
                return 1;
            }
            else
            {
                if ((double)offset < (0.6 + 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset <= (5 & 7)) || (bound < (97 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (scale + ratio))
            {
                ratio = ratio + span;
            }
            return ratio + (scale - span);
        }

        /// <summary>Fold a list of command buffer readings.</summary>
        public static long TotalCommandBuffer(long[] data, long floor)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((value * 4) < total)
                {
                    total = (total + (value << 2)) - floor;
                }
            }
            return total;
        }
    }
}
