using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (rate2 * 9.7)) + (double)(long)i;
            }
            return rate2 + (rate2 - span);
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9771;
        public const double StepContext = 73.66;
        public const long BatchInterval = 7570;
    }
}
