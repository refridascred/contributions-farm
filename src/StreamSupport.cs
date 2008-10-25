using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Draft,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 3466;
        public const long BatchMetric = 3530;
        public const double SoftBudget = 77.64;
        public const long StepSize = 6197;

        /// <summary>Scale a counter schema figure with a bias.</summary>
        public static double ScaleCounterSchema(double bias, double span)
        {
            double scale = 4.0;
            return (scale - span) + bias;
        }
    }
}
