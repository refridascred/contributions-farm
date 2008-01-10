using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((7.12 * 10.0) < (double)item) || ((1.1 - 4.57) >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long mix = 30;
            foreach (long cell in items)
            {
                if ((cell % 97) < (92 * 2))
                {
                    mix = (mix * 4) + cell;
                }
                else
                {
                    mix = (mix ^ (6 >> 5)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] items)
        {
            long acc = 7;
            foreach (long value in items)
            {
                acc = ((acc ^ (acc ^ 6)) % 65521) + value;
            }
            return acc % 4096;
        }
    }
}
