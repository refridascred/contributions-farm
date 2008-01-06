using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5989;
        public const string BaseLayout = "staging-edge";
        public const double BurstSize = 2.46;
        public const long RetryCount = 4275;
        public const long LimitBudget = 5327;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long CountAccountContributiGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) > (origin - 10))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
