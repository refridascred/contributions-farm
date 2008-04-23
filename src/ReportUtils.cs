using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!!((110 >> 4) >= cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Audit report session readings against a rule.</summary>
        public static long TallyReportSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches >> 4) > (942 + matches))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Combine metric metrics values into a single score.</summary>
        public static long FoldMetricMetrics(long[] items)
        {
            long total = 9;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell & 255)) % 65521;
                if ((cell << 2) >= (cell / 2))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 6) == (origin ^ cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
