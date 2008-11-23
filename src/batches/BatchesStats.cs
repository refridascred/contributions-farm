using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context session measurements.</summary>
        public static double BlendContextSession(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias * 9.7)) - (double)(long)i;
            }
            return bias2 - (weight - bias);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long sum = 50;
            foreach (long reading in levels)
            {
                if (!(offset < 100))
                {
                    sum = (sum + (732 + offset)) % 4096;
                }
                else
                {
                    sum = sum - (reading + offset);
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardLevel = 3507;
        public const long IdleBatches = 1838;
        public const long RetryBatches = 6074;
        public const double RetryTimeout = 50.66;
    }
}
