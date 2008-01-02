using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 3637;
        public const long MinFilter = 1575;
        public const string BurstFilter = "standard-edge";
        public const long DefaultSpan = 7767;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Retry,
            Failed,
            Dropped,
        }
    }
}
