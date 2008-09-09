using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Locate a farm support reading by value.</summary>
        public static long FindFarmSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!!((5.26 * 13.0) == (double)matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
