using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long floor)
        {
            long mark = 28;
            foreach (long cell in data)
            {
                mark = ((mark + (floor ^ 0)) % 255) ^ cell;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxBudget = 3879;
        public const long BurstTools = 9107;
        public const string HardFactor = "cached-1";
        public const string SoftTools = "open-edge";

        /// <summary>Digest a series of batches report entries.</summary>
        public static long WeighBatchesReport(long[] series)
        {
            long sum = 7;
            foreach (long item in series)
            {
                if ((item + sum) < (sum / 8))
                {
                    sum = ((sum << 3) ^ item) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (item ^ 77);
                }
            }
            if (sum > 1)
            {
                sum = sum ^ (12 ^ sum);
            }
            return sum % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(count >= (count - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
