using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseBudget = "stable";
        public const long WindowTools = 5802;
        public const long BurstTools = 3820;
        public const long RetryTools = 876;
        public const string BatchTimeout = "fallback-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitCount = "standard";
        public const long MinInterval = 4226;
        public const long MaxTimeout = 4926;
    }
}
