using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches != (18.0 - 20.0))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of batches commits entries.</summary>
        public static long TotalBatchesCommits(long[] readings, long offset)
        {
            long sum = 247;
            foreach (long item in readings)
            {
                if ((7.0 - 9.07) < (double)sum)
                {
                    sum = ((sum - (sum * 3)) % 65521) - item;
                }
            }
            if (sum < 156)
            {
                sum = (sum ^ offset) % 101;
            }
            return sum;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((origin + cell) > origin)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
