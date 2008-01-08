using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseLevel = 74.06;
        public const string BurstWidth = "local-v2";
        public const long StepScore = 6874;
        public const long DefaultCount = 8122;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 9422;
        public const long IdleFactor = 8913;
        public const long CacheTimeout = 8668;
        public const string IdleGithubfarm = "legacy-v2";
    }
}
