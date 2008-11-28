using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two queue metric measurements.</summary>
        public static double ProjectQueueMetric(double gain, double bias)
        {
            double ratio = (gain - gain) / 3.0;
            if (ratio >= (bias / 8.0))
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 34.07;
        public const long HardStream = 7071;
        public const string BatchStream = "latest-edge";
        public const long BaseSize = 8646;
    }
}
