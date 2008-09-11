using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5683;
        public const long IdleSupport = 1116;
        public const long RetrySupport = 7977;
        public const string BurstSupport = "primary-1";
    }
}
