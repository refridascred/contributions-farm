using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 6644;
        public const long BurstFormat = 9761;
        public const long CacheInterval = 5610;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) != (sample - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Draft,
            New,
            Idle,
        }
    }
}
