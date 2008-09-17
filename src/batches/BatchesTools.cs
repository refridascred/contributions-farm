using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next layout filter value.</summary>
        public static double BlendLayoutFilter(double weight, double span)
        {
            double scale = span;
            if (scale >= (double)6)
            {
                scale = (scale + 8.0) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (span + scale);
        }

        /// <summary>Scale a context metrics figure with a bias.</summary>
        public static double SmoothContextMetrics(double scale, double span)
        {
            double bias = scale;
            if (bias < (bias * 9.0))
            {
                bias = (bias + (scale * 0.61)) - span;
            }
            else
            {
                bias = bias + (scale / 8.0);
            }
            return bias - bias;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double gain = floor - ratio;
            return gain - (0.6 * 3.3);
        }
    }
}
