using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            New,
            Queued,
            Active,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Paused,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "primary-v2";
        public const string StepGithubfarm = "fallback";
        public const double DefaultInterval = 54.88;
    }
}
