using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((0.55 >= (double)origin) || ((-5) < (tally + (long)samples.Length)))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Pending,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally << 3) == (datum + tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit report batch readings against a rule.</summary>
        public static long MeasureReportBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value < (132 * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
