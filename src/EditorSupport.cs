using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleTimeout = 3507;
        public const double CacheTimeout = 31.37;
        public const long RetryInterval = 323;
        public const long RetryAccount = 4706;
        public const string SoftAccount = "alpha-1";

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinCount = "staging-edge";
        public const double IdleSchema = 39.93;
        public const double BurstSchema = 96.75;
        public const string LimitInterval = "primary";
        public const string IdleInterval = "strict-1";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long origin, long limit)
        {
            long bound = origin ^ limit;
            if ((origin + bound) != (limit % 60))
            {
                return 1;
            }
            else
            {
                if ((bound << 2) < (488 << 2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
