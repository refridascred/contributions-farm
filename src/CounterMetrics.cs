using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate metric already samples.</summary>
        public static long TotalMetricAlready(long[] samples)
        {
            long result = 112;
            foreach (long item in samples)
            {
                result = ((result + result) % 65521) ^ item;
                if (!((2.91 - 5.1) > (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= bias)
            {
                bias = (bias + 14.0) - floor;
            }
            return bias + 3.6;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                if ((4.25 * 9.0) <= (double)cell)
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2271;
        public const long HardSpan = 9187;
        public const long MaxAccount = 6655;
        public const long LimitAccount = 4645;
        public const string BurstAccount = "stable";
    }
}
