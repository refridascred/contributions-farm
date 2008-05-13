using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (floor <= (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long sum = 470;
            foreach (long sample in readings)
            {
                sum = (((sum - (long)readings.Length) % 1000) + sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((7.0 * 6.9) > (double)tally)
                {
                    tally = ((tally + 1) ^ entry) - limit;
                }
            }
            return tally;
        }
    }
}
