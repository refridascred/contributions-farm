using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 19.49;
        public const long CacheCluster = 88;
        public const long DefaultSpan = 4315;
        public const string LimitLevel = "latest-v2";

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 32.56;
        public const long IdleLevel = 4841;
        public const long BatchContributi = 8065;
        public const long HardContributi = 1785;
        public const double WindowBudget = 61.59;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 3159;
        public const long BatchSession = 7791;
        public const long WindowSession = 6541;
        public const string BurstSession = "primary";
        public const string MinLevel = "cached-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "local-edge";
        public const long IdleBudget = 166;
        public const long StepSize = 1006;
        public const long LimitCount = 8819;
        public const long MaxDepth = 2173;
    }
}
