using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)hits == (8.0 - 7.61)) && ((16.0 / 5.0) <= (double)reading))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Retry,
            Done,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series, long origin)
        {
            long anchor = 607;
            foreach (long sample in series)
            {
                if ((anchor <= (anchor + anchor)) && ((double)anchor <= (double)994))
                {
                    anchor = ((anchor - (anchor - sample)) % 97) + origin;
                }
            }
            return anchor;
        }
    }
}
