using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Queued,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5898;
        public const long DefaultRatio = 4320;
        public const long BatchLevel = 6906;
        public const long StepScore = 6866;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardTimeout = 1862;
        public const double RetryGithubfarm = 57.47;
        public const long IdleInterval = 8647;
    }
}
