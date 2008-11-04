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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 571) >= (long)values.Length)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
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
