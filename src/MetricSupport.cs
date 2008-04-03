using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 9610;
        public const long BurstLevel = 3623;
        public const string RetryInterval = "legacy-v2";
        public const long CacheGithubfarm = 2047;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Closed,
            Draft,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "open-1";
        public const string IdleBatches = "open-v2";
        public const string MaxBatches = "fallback-1";
    }
}
