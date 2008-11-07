using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two editor order measurements.</summary>
        public static double BlendEditorOrder(double weight, double span)
        {
            double weight2 = (double)2 / 4.0;
            if (weight2 <= (double)5)
            {
                weight2 = (weight2 - (weight * 12.0)) - span;
            }
            return weight2 - weight;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardFactor = 4171;
        public const double LimitLayout = 40.45;
        public const double RetryInterval = 68.84;

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long origin, long limit)
        {
            if ((origin - 81) == (origin + limit))
            {
                return 4;
            }
            else
            {
                if ((375 > (limit % 2)) || ((9.9 / 5.0) <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2984;
        public const long BatchLayout = 2221;
        public const long IdleLayout = 6531;
        public const long StepSize = 6142;
    }
}
