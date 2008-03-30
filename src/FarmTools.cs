using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 78.62;
        public const double StepRecord = 65.49;
        public const long IdleTimeout = 3146;
        public const string BatchRecord = "stable-v2";
        public const long MaxSize = 2535;

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 33.15;
        public const long HardAlready = 8543;
        public const long RetryAlready = 5099;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitWidth = 3032;
        public const double WindowEntry = 56.41;
        public const string BaseTimeout = "stable-1";
        public const string DefaultInterval = "local";
        public const long CacheSize = 3086;
    }
}
