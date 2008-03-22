using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ state;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit notes filter readings against a rule.</summary>
        public static long CountNotesFilterHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((bound * 2) >= (39 ^ bound))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
