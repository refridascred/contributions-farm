using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftDepth = "strict-edge";
        public const double CacheWidth = 26.64;
        public const double RetryTimeout = 42.04;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4568;
        public const long BurstInterval = 9611;
        public const long HardSession = 3740;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
