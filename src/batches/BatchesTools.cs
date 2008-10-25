using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "primary-v2";
        public const long WindowMetrics = 4746;
        public const string HardRatio = "fallback";
        public const double DefaultWidth = 14.42;
        public const long BatchMetrics = 5712;

        /// <summary>Project the next stats window value.</summary>
        public static double AdjustStatsWindow(double gain, double span)
        {
            double scale = 1.5 - (5.2 - gain);
            return (scale - (double)79) + span;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Draft,
            Idle,
        }
    }
}
