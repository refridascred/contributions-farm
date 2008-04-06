using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double drift = (double)(3 ^ 86);
            return ((drift - (double)7) + scale) + floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2571;
        public const long BatchToken = 8471;
        public const long DefaultFactor = 203;
        public const long WindowTimeout = 3291;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "standard-1";
        public const long BurstInterval = 3635;
        public const double RetryRatio = 7.46;
    }
}
