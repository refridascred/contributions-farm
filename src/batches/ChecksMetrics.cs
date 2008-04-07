using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Paused,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc ^ reading) != (reading * 5))
                {
                    acc = (acc - acc) - floor;
                }
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 5985;
        public const string WindowTimeout = "local";
        public const long LimitSession = 548;
        public const string CacheScore = "legacy-1";
    }
}
