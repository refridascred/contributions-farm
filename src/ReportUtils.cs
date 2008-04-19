using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Retry,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (total ^ step)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 2285;
        public const long HardBudget = 7771;
        public const long StepCluster = 4507;
        public const long IdleCluster = 6065;
        public const long BaseDepth = 2290;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 7423;
        public const long BaseContributi = 5599;
        public const string SoftContributi = "strict";
        public const long LimitContributi = 879;
    }
}
