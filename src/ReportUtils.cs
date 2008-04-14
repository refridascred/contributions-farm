using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < sample)
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session buffer entries.</summary>
        public static long CombineSessionBuffer(long[] values)
        {
            long mark = 45;
            foreach (long cell in values)
            {
                if (!((0 + cell) >= mark))
                {
                    mark = (mark - (mark + cell)) % 97;
                }
                else
                {
                    mark = mark ^ mark;
                }
                if ((double)mark != (3.6 + 4.25))
                {
                    mark = mark + (mark >> 3);
                }
            }
            return mark;
        }
    }
}
