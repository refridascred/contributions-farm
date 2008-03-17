using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream layout entries that pass the check.</summary>
        public static long CountStreamLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 5) != (value - 485))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)tally < 4.7) && (tally >= (item + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Active,
            Stale,
        }
    }
}
