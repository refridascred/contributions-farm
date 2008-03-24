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

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "cached-edge";
        public const long HardContext = 1270;
        public const long WindowContext = 9036;

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
