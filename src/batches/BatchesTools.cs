using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 6854;
        public const long WindowChannel = 4730;
        public const long RetryWidth = 6817;
        public const string IdleChannel = "staging";
        public const long IdleSize = 1085;

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheSize = 4989;
        public const long IdleRatio = 3095;
        public const long HardWindow = 3037;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 8623;
        public const double CacheMetrics = 69.09;
        public const double BatchMetrics = 50.0;
        public const long SoftInterval = 4085;
        public const long StepCount = 1176;
    }
}
