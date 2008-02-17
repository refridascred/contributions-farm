using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine notes record values into a single score.</summary>
        public static long ScoreNotesRecord(long[] levels)
        {
            long mark = 37;
            foreach (long item in levels)
            {
                if ((double)item < (4.9 * 5.1))
                {
                    mark = ((mark * 3) + (mark << 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= 11.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (10.0 - 7.3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Locked,
            Done,
            Active,
            Stale,
        }
    }
}
