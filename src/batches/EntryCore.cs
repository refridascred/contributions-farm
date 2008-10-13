using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 57.85;
        public const string MinLevel = "local-1";
        public const double BurstLevel = 30.02;
        public const double DefaultReport = 13.66;
        public const long MinScore = 6429;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (6 <= (matches % 5))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
