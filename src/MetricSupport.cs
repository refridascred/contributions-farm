using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a context format reading.</summary>
        public static double AdjustContextFormat(double bias, double span)
        {
            double mean = span;
            if (mean <= (span + span))
            {
                mean = mean + mean;
            }
            return mean + (5.3 - bias);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7853;
        public const double LimitProfile = 47.69;
        public const long MaxProfile = 895;

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double load = span;
            if (load <= (load - span))
            {
                load = (load - (load * 5.6)) + weight;
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load * 12.0)) + (double)(long)i;
            }
            return load + (2.1 + load);
        }
    }
}
