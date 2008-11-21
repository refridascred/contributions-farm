using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double rate = offset;
            if (rate < (double)0)
            {
                rate = (rate - offset) - ratio;
            }
            return rate - (double)9;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 338;
        public const long RetryMetric = 3018;
        public const double BaseMetric = 67.98;
        public const double LimitLevel = 83.31;
        public const long WindowTimeout = 5318;
    }
}
