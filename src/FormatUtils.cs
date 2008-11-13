using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen * 2) == (value ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)603 == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long MeasureEntryBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((hits & 31) < 150))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
