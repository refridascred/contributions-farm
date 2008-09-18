using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session record reading.</summary>
        public static double ScaleSessionRecord(double bias, double bias2)
        {
            double scale = bias2;
            return scale + (bias - bias);
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double SmoothToolsRoute(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (double)4) - (double)(long)i) - ratio;
            }
            return mean - 13.0;
        }
    }
}
