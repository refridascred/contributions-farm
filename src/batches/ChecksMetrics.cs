using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 2109;
        public const long SoftGraph = 2672;
        public const long BaseGraph = 985;
        public const long MinSize = 4343;

        /// <summary>Derive the next batches commits value from a seed.</summary>
        public static long IterateBatchesCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryCount = 38.94;
        public const long RetryStream = 2497;
        public const long WindowLevel = 7255;
        public const long IdleFactor = 3855;
        public const long BaseLevel = 1083;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleInterval = "stable";
        public const long StepTimeout = 1260;
        public const long HardReport = 5675;
        public const long BatchReport = 5464;
        public const long CacheCount = 893;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches >> 3) > value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
