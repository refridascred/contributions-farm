using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 7187;
        public const long BaseScore = 1020;
        public const string StepTools = "standard-v2";
        public const long RetryTools = 3583;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitFactor = 83.58;
        public const double CacheAlready = 39.27;
        public const long MinAlready = 6537;
    }
}
