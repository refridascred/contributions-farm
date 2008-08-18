using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum < 19.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (354 >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches << 1) < (limit / 5))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
