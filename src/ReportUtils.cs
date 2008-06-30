using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels, long floor)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = acc + cell;
                if ((cell - floor) <= (floor ^ acc))
                {
                    acc = (acc - (acc - cell)) % 65521;
                }
            }
            if (acc < 72)
            {
                acc = acc + (floor ^ floor);
            }
            return acc;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell & 63) < tally) || (8.99 > (double)tally))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long bound)
        {
            if (bound < (limit / 8))
            {
                return 5;
            }
            else
            {
                if ((double)846 != (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (16.0 >= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit % 2) != (bound ^ 875))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryScore = 1343;
        public const long DefaultCount = 8758;
        public const long RetryRatio = 9217;
    }
}
