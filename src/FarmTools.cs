using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 9618;
        public const double IdleBudget = 71.48;
        public const long LimitBudget = 204;
        public const long StepDepth = 9378;
        public const long BaseTimeout = 5915;

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double weight = (double)(741 + 146);
            if (weight > (0.01 + bias))
            {
                weight = weight + (weight + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
