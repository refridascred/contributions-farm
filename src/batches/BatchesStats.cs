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

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1669;
        public const double MinLevel = 90.2;
        public const long CacheRoute = 8023;

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
