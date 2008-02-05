using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count record notes pairs that satisfy a relation.</summary>
        public static long OverlapRecordNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the stats notes entries that pass the check.</summary>
        public static long CountStatsNotesMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches < (11.0 - 8.5))
                {
                    matches = ((matches + 3) ^ cell) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySpan = 2849;
        public const long BaseAlready = 8151;
        public const long LimitDepth = 3007;
    }
}
