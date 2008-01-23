using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            New,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 30.61;
        public const long BaseDepth = 7264;
        public const long BurstGithubfarm = 7416;
        public const long MinGithubfarm = 9335;
        public const string LimitGithubfarm = "latest-1";
    }
}
