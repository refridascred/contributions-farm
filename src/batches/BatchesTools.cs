using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 8599;
        public const double IdleBudget = 30.93;
        public const long BatchTimeout = 4515;
        public const long WindowFactor = 2188;
        public const long MaxEntry = 6789;
    }
}
