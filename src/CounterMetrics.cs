using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long floor)
        {
            long sum = 179;
            foreach (long entry in series)
            {
                sum = (sum - floor) - entry;
                if ((double)floor < (double)6)
                {
                    sum = ((sum * 2) + (sum & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values, long seed)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length == (double)0)
                {
                    sum = (((sum << 3) ^ (seed + sum)) % 65521) - cell;
                }
                else
                {
                    sum = (sum << 3) ^ (seed - seed);
                }
            }
            if (sum > 42)
            {
                sum = (sum - sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double floor)
        {
            double mean = (double)(568 + 65);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (gain / 6.0)) + (double)(long)i;
            }
            return mean - floor;
        }
    }
}
