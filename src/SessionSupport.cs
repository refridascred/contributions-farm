using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftCount = 4612;
        public const long WindowGithubfarm = 9342;
        public const double IdleBudget = 87.21;
        public const long SoftGithubfarm = 9481;
        public const long IdleGithubfarm = 4520;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Dropped,
            Failed,
            Queued,
        }
    }
}
