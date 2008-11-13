using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double ratio = (4.0 * 15.0) - (gain + 8.69);
            if (ratio >= (bias * 14.0))
            {
                ratio = ratio - (ratio - bias);
            }
            return ratio + gain;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Draft,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 8008;
        public const long RetryDepth = 9982;
        public const long BaseDepth = 6100;
    }
}
