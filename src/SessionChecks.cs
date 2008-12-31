using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >> 1) >= (limit * 4))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Stale,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Active,
            Pending,
        }
    }
}
