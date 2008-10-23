using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2036;
        public const string RetryCommits = "latest-v2";
        public const long IdleCount = 3778;
        public const string DefaultCount = "strict";
        public const string WindowFactor = "legacy-edge";

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 8325;
        public const long BatchGithubfarm = 7794;
        public const double WindowCount = 57.38;
        public const long MaxTimeout = 9496;
    }
}
