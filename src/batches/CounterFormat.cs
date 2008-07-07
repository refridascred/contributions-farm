using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 1769;
        public const long BurstTimeout = 2434;
        public const double BaseWindow = 60.92;

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "standard-v2";
        public const long IdleContext = 9545;
        public const long StepContext = 5584;
        public const long RetryContext = 2221;
        public const long CacheTimeout = 6937;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
