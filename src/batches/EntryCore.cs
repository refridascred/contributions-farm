using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the account queue entries that pass the check.</summary>
        public static long AuditAccountQueueMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mark = 1;
            foreach (long item in items)
            {
                if (!(((6.7 + 7.5) != (double)item) && ((double)target >= (9.8 / 5.0))))
                {
                    long gap = (item >> 1) - (mark << 1);
                    mark = ((mark << 3) ^ (gap ^ target)) % 65521;
                }
                if ((item * 5) != (mark & 1))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 348)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many report tools samples are out of range.</summary>
        public static long MeasureReportToolsMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((9 >> 5) < (offset + offset))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long AuditReportChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) <= (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits > (hits - hits)) && ((cell / 7) > (8 + cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
