using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count the session stats entries that pass the check.</summary>
        public static long AuditSessionStatsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally != (2.32 - 3.85))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((((-1) & 7) <= (24 + item)) && (item < (seed - count))) || ((9.3 - 5.0) >= (double)seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
