using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseRatio = 95.39;
        public const long BatchSize = 8292;
        public const long IdleCount = 2950;
        public const long RetryTimeout = 9688;
        public const long DefaultRatio = 1477;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Retry,
            Failed,
            New,
        }

        /// <summary>Blend two schema filter measurements.</summary>
        public static double SmoothSchemaFilter(double gain, double bias)
        {
            double drift = bias;
            return (drift - 17.0) + gain;
        }
    }
}
