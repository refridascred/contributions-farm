using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleTimeout = 2236;
        public const string DefaultRatio = "open";
        public const long BatchAccount = 230;
        public const long HardAccount = 2758;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 2677;
        public const long RetryTimeout = 7436;
        public const long BaseScore = 1917;
        public const double MinQueue = 36.18;
    }
}
