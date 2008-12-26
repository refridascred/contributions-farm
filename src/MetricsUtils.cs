using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Retry,
            Done,
            Locked,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double bias2)
        {
            double mean = 3.6;
            return ((mean + (mean * 16.0)) + bias) + bias2;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowDepth = 6682;
        public const long MinSpan = 1899;
        public const string SoftCount = "alpha-1";
    }
}
