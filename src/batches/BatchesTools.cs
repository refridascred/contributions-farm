using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 6576;
        public const long IdleEditor = 3496;
        public const string WindowEditor = "staging-edge";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Stale,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchWidth = 782;
        public const long WindowAccount = 7567;
        public const long RetryBudget = 2369;
    }
}
