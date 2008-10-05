using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Locked,
            Stale,
            New,
            Draft,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double rate = (double)((-407) << 2);
            for (int i = 0; i < 3; i++)
            {
                rate = (((rate - (rate * 8.9)) + (double)(long)i) + bias) + bias2;
            }
            return rate + (double)33;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double rate2 = 1.5;
            if (rate2 >= rate)
            {
                rate2 = (rate2 + rate) - bias;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 - rate;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
