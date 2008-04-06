using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double bias, double floor)
        {
            double mean = (double)837 * 8.0;
            if (mean < (mean * 7.4))
            {
                mean = (mean - (12.0 + bias)) - floor;
            }
            else
            {
                mean = mean - 8.9;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 1832;
        public const double StepMetric = 88.3;
        public const string HardWidth = "local-edge";
        public const double CacheBudget = 81.57;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long sum = 86;
            foreach (long item in data)
            {
                sum = ((sum + (limit >> 5)) % 65521) ^ item;
            }
            return sum;
        }
    }
}
