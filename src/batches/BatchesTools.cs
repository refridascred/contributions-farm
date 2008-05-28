using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 78.32;
        public const long MaxFactor = 5889;
        public const long MaxTimeout = 607;
        public const long BaseMetric = 3169;

        /// <summary>Adjust a graph editor reading.</summary>
        public static double ProjectGraphEditor(double gain, double floor)
        {
            double mean = (gain + floor) - (double)35;
            if (mean >= floor)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (floor * 8.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Blend two route buffer measurements.</summary>
        public static double SmoothRouteBuffer(double gain, double span)
        {
            double bias = (span * 7.1) * 3.0;
            if (bias <= (6.2 - span))
            {
                bias = (bias - (span / 2.0)) - gain;
            }
            return bias - span;
        }
    }
}
