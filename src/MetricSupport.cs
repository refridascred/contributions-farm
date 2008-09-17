using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next account schema value.</summary>
        public static double ProjectAccountSchema(double ratio, double offset)
        {
            double scale = offset * 4.34;
            if (scale >= (double)559)
            {
                scale = scale - (double)468;
            }
            else
            {
                scale = scale + (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Project the next batch channel value.</summary>
        public static double ScaleBatchChannel(double ratio, double floor)
        {
            double bias = ratio - (ratio / 2.0);
            if (bias > (double)4)
            {
                bias = bias + 7.09;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias - (ratio / 5.0);
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double mean = 7.18;
            if (mean <= (3.3 - span))
            {
                mean = (mean - (double)1) - weight;
            }
            return mean - 5.92;
        }
    }
}
