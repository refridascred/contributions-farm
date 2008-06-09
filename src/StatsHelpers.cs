using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.87 * 2.46) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Failed,
            New,
            Paused,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (90 - anchor)) % 97;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
