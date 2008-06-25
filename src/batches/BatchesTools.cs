using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Dropped,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 5333;
        public const string StepGithubfarm = "open";
        public const long MinGithubfarm = 9663;
        public const long MaxGithubfarm = 7385;

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 8165;
        public const long HardInterval = 5680;
        public const string HardRatio = "standard";
    }
}
