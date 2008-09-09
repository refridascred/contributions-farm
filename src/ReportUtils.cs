using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next queue session value.</summary>
        public static double SmoothQueueSession(double gain, double floor)
        {
            double mean = gain * 4.7;
            if (mean <= gain)
            {
                mean = (mean - (mean * 5.8)) - floor;
            }
            return mean - (gain + gain);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Closed,
            Stale,
            Failed,
            New,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Synced,
            Retry,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 7283;
        public const long IdleTimeout = 9870;
        public const double CacheCount = 20.89;
        public const long IdleBatch = 5850;
        public const string RetryWidth = "local-edge";
    }
}
