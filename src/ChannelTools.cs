using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 4856;
        public const long MaxGithubfarm = 669;
        public const long MinWidth = 2237;
        public const long IdleGithubfarm = 7614;
        public const double RetryLevel = 13.21;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 460;
        public const double CacheTools = 38.12;
        public const long SoftTools = 574;
    }
}
