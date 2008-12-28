using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a route report reading.</summary>
        public static double AdjustRouteReport(double gain, double span)
        {
            double rate = span;
            if (rate <= (double)37)
            {
                rate = rate - (span - gain);
            }
            return rate - gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 15.16;
        public const long SoftChecks = 7053;
        public const long LimitChecks = 689;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double gain = ratio;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span * 7.7)) + (double)(long)i;
            }
            return gain - (double)3;
        }
    }
}
