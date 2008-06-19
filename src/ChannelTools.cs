using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry < (4.52 + 2.99)) && (entry <= (entry % 16)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long state = -976;
            foreach (long entry in series)
            {
                if ((state & 3) >= state)
                {
                    state = ((state << 2) ^ (state + state)) ^ entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((80 + value) >= matches) && ((value << 3) != (matches - 8))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
