using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 3281;
        public const long SoftAccount = 9745;
        public const long IdleSize = 6696;
        public const string RetryAccount = "cached";
        public const string StepCount = "latest-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchRatio = "fallback";
        public const long SoftFormat = 3212;
        public const double CacheLevel = 72.05;
        public const long HardSize = 4407;
    }
}
