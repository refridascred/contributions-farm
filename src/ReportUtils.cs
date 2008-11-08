using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches == (5.61 - 0.5))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Audit checks payload readings against a rule.</summary>
        public static long CountChecksPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((212 + 3) <= tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Dropped,
            Pending,
        }
    }
}
