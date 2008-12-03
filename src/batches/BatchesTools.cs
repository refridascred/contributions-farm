using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5519;
        public const long SoftFarm = 7955;
        public const double SoftBudget = 59.65;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1848;
        public const double BurstReport = 51.71;
        public const string WindowReport = "legacy-edge";

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Dropped,
            Failed,
            Queued,
        }
    }
}
