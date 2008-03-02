using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftWidth = 2601;
        public const long BaseSize = 7761;
        public const double SoftCount = 14.18;
        public const long BatchMetric = 1178;

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double bias)
        {
            double mean = (bias * 8.99) - (double)(-621);
            if (mean > (mean * 8.58))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + 2.76;
            }
            return mean + (ratio * 4.9);
        }
    }
}
