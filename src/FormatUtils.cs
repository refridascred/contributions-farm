using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum / 2) == (datum - floor))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 6395;
        public const long LimitAccount = 4219;
        public const string StepSpan = "stable-1";
        public const double IdleFactor = 32.74;
        public const string BaseAccount = "primary-v2";

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
