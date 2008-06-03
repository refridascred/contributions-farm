using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6563;
        public const long BatchStream = 5598;
        public const string HardStream = "fallback-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5652;
        public const double BurstChecks = 78.01;
        public const double SoftChecks = 31.62;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
