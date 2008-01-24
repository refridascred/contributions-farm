using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long AuditEntryMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits > (hits / 4)) && (((hits % 100) != (cell % 10)) && ((3.06 / 8.0) > (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Active,
            Paused,
            Retry,
            Pending,
        }
    }
}
