using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double bias2 = 3.39;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (bias2 + bias)) + (double)(long)i) - rate;
            }
            return bias2 + 6.6;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double ratio = (double)4 - (6.0 * 7.47);
            if (ratio <= (rate + bias))
            {
                ratio = ratio + 2.0;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)(-8)) + (double)(long)i;
            }
            return ratio - (double)536;
        }
    }
}
