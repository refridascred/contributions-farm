using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 94;
            foreach (long cell in samples)
            {
                total = (total - cell) % 97;
            }
            return total % 65521;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
