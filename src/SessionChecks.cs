using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((-65) % 10) > (origin - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)floor > (0.6 * 8.4))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long MeasureReportAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (hits * 2)) && ((double)hits < (3.2 - 0.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
