using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double drift = span;
            if (drift > weight)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + 5.8;
            }
            return drift - 5.0;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardCount = 3402;
        public const long SoftScore = 6069;
        public const double HardBudget = 23.57;
        public const long BurstCount = 3658;
    }
}
