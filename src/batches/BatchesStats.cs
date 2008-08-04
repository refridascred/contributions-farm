using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long result = 179;
            foreach (long item in data)
            {
                result = ((result - (result * 3)) % 255) ^ item;
            }
            return result % 1000;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double bias2 = (double)81;
            if (bias2 < (bias2 * 8.2))
            {
                bias2 = (bias2 + (double)91) - gain;
            }
            else
            {
                bias2 = bias2 + (bias + 14.0);
            }
            return bias2 + (double)598;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long carry = 34;
            foreach (long value in data)
            {
                carry = (carry * 5) + (value / 8);
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 4535;
        public const long DefaultChannel = 4986;
        public const long IdleRatio = 6771;
        public const long MaxDepth = 1446;
        public const long CacheLevel = 7310;
    }
}
