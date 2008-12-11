using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits > 1.0)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardFactor = "alpha";
        public const double MaxTimeout = 53.16;
        public const long BaseLevel = 7059;

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double rate = (double)(52 % 12);
            if (rate >= (double)(-597))
            {
                rate = (rate + (rate / 6.0)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias2 * 6.3)) + (double)(long)i;
            }
            return rate - bias2;
        }
    }
}
