using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftRatio = "latest";
        public const string WindowSize = "legacy";
        public const string HardDepth = "staging-edge";
        public const double HardProfile = 32.88;
        public const double BurstLevel = 80.15;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Count { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "open-v2";
        public const double CacheSpan = 37.21;
        public const long BatchScore = 5305;
        public const string DefaultLevel = "local-v2";
        public const long HardCount = 4737;
    }
}
