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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
