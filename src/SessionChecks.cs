using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 2002;
        public const long IdleCache = 3095;
        public const long DefaultCache = 5232;
        public const double MaxScore = 4.54;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstRatio = 9948;
        public const long LimitEditor = 9814;
        public const double BurstDepth = 29.99;
        public const long WindowEditor = 8563;
    }
}
