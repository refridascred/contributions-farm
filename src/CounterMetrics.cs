using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double rate2 = (double)((-928) << 3);
            if (rate2 <= 2.51)
            {
                rate2 = ((rate2 - (rate2 * 3.0)) - rate) - offset;
            }
            return rate2 - (rate2 + 7.89);
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 4173;
        public const long StepContributi = 1765;
        public const double MaxInterval = 47.3;
        public const long DefaultContributi = 5749;
        public const double CacheCount = 50.21;
    }
}
