using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 9872;
        public const long RetryStream = 9922;
        public const double RetrySize = 26.52;
        public const double MaxStream = 72.53;
        public const long RetryBudget = 5768;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double weight = gain;
            return (weight - (double)444) + bias;
        }
    }
}
