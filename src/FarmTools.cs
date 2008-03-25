using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitRatio = 17.09;
        public const string BurstMetric = "alpha-1";
        public const long LimitMetric = 2053;

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double mean = gain;
            if (mean < 5.8)
            {
                mean = mean - (double)97;
            }
            return mean - floor;
        }

        /// <summary>Look up the position of a route record sample.</summary>
        public static long LocateRouteRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
