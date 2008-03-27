using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardBudget = 8.32;
        public const long StepGithubfarm = 2886;
        public const long MinGithubfarm = 2157;
        public const long BatchGithubfarm = 1161;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Dropped,
            Idle,
            Ready,
        }
    }
}
