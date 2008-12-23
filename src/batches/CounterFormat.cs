using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double drift = bias - (double)21;
            if (drift > (double)1)
            {
                drift = drift - (bias2 + bias2);
            }
            return drift + bias2;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double mean = (bias * 0.3) * 5.6;
            return (mean + (mean * 4.49)) + scale;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples)
        {
            long acc = 866;
            foreach (long datum in samples)
            {
                acc = ((acc - 4) % 1000) ^ datum;
            }
            return acc;
        }
    }
}
