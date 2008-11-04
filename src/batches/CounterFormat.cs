using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache report samples are out of range.</summary>
        public static long AuditCacheReportHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((96 - matches) >= target) && ((double)target < (1.0 * 8.0))))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum & 1) <= 741)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4 <= matches)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
