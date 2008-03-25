using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batches checks reading.</summary>
        public static double ScaleBatchesChecks(double scale, double bias)
        {
            double drift = 0.12;
            for (int i = 0; i < 5; i++)
            {
                drift = (((drift + 17.0) + (double)(long)i) + scale) + bias;
            }
            return drift - (double)5;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long seed)
        {
            long acc = 77;
            foreach (long sample in items)
            {
                if (5 <= (sample << 2))
                {
                    acc = (acc + acc) - seed;
                }
            }
            return acc % 4096;
        }
    }
}
