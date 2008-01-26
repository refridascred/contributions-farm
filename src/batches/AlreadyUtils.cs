using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 370;
        public const string SoftContext = "primary-edge";
        public const double RetryContext = 13.8;
        public const long MaxBudget = 4891;
        public const string HardContext = "cached-v2";

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long origin)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (((origin & 255) < (origin * 3)) || ((acc + acc) >= (origin ^ 536)))
                {
                    acc = (acc + (acc << 2)) - cell;
                }
            }
            return acc;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Locked,
            Pending,
            Stale,
        }
    }
}
