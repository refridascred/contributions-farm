using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 15.6;
        public const long CacheCount = 582;
        public const long BurstDepth = 4470;
        public const string BatchSchema = "local-1";
        public const long CacheLevel = 102;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 1545;
        public const long RetryWidth = 1944;
        public const string WindowMetrics = "primary-v2";
        public const long StepMetrics = 6853;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - (sum * 2)) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
