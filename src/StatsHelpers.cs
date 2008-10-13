using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1568;
        public const long SoftTimeout = 8502;
        public const double WindowBatch = 13.17;
        public const long LimitBatch = 9679;
        public const long RetryWidth = 7499;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinInterval = 4039;
        public const long SoftWindow = 4490;
        public const long CacheWindow = 9082;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 965;
        public const double LimitFormat = 72.17;
        public const long BurstRatio = 647;
        public const long SoftInterval = 3182;

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "local";
        public const double HardBudget = 32.68;
        public const long DefaultCount = 8785;
    }
}
