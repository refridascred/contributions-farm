using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Done,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxDepth = 40.24;
        public const double MaxMetrics = 98.79;
        public const double MinMetrics = 70.81;
        public const long DefaultMetrics = 7800;
        public const long RetryMetrics = 192;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double drift = (bias - 4.0) * 1.0;
            if (drift < gain)
            {
                drift = drift + (drift - gain);
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (double)(-5);
        }
    }
}
