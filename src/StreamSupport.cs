using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheFactor = 1127;
        public const long SoftSchema = 8731;
        public const long RetryTimeout = 1569;
        public const double IdleSchema = 0.51;
        public const double WindowSchema = 74.59;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 8475;
        public const long CacheRoute = 8038;
        public const string HardScore = "strict-edge";
        public const long WindowRoute = 5823;

        /// <summary>Define session limits and defaults.</summary>
        public const string StepFactor = "standard-v2";
        public const long CacheBudget = 1061;
        public const string WindowScore = "strict";
        public const long HardSession = 5050;
    }
}
