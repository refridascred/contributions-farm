using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-1";
        public const long BurstInterval = 7783;
        public const double MinEntry = 94.47;
        public const double BatchEntry = 90.53;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSpan = 8491;
        public const string RetryCount = "cached-v2";
        public const long IdleGraph = 3948;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
