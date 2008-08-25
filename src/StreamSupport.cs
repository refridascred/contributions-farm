using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchSize = "local";
        public const long RetryCache = 4174;
        public const long LimitCache = 8898;
        public const long SoftLevel = 3110;
        public const long DefaultCache = 4885;

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstBudget = "legacy-1";
        public const string RetrySession = "alpha-edge";
        public const long CacheSpan = 8734;
        public const long CacheFactor = 4374;
        public const long HardSession = 9570;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 8964;
        public const long BurstQueue = 3284;
        public const long MinInterval = 1278;
        public const long SoftDepth = 2149;
    }
}
