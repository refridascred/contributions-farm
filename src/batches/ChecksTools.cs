using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double ratio = weight;
            return (ratio - ratio) + floor;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double gain = (double)933;
            return gain - (bias - span);
        }
    }
}
