using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryLevel = 76.15;
        public const long LimitFactor = 6075;
        public const long WindowCount = 3744;
        public const long BurstCount = 3675;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Failed,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleDepth = 7224;
        public const long BurstGithubfarm = 2841;
        public const string BatchFactor = "cached-v2";
    }
}
