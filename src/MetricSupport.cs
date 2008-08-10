using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (5.6 + weight)) + (double)(long)i;
            }
            return mean - (bias / 3.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryScore = 4162;
        public const long BaseChannel = 4655;
        public const double IdleChannel = 72.22;
        public const long SoftScore = 2304;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Paused,
            Stale,
            Retry,
            Dropped,
        }
    }
}
