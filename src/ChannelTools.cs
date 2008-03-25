using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit commits stats readings against a rule.</summary>
        public static long TallyCommitsStatsOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < 2.0)
                {
                    seen = ((seen + 1) ^ item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long offset)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                if ((acc + offset) >= value)
                {
                    acc = acc + (acc / 7);
                }
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)bound >= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
