using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long offset2)
        {
            if ((647 - offset2) < offset2)
            {
                return 6;
            }
            else
            {
                if ((15.0 * 0.26) >= (double)offset2)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples)
        {
            long carry = 1;
            foreach (long value in samples)
            {
                if (carry < ((long)samples.Length & 31))
                {
                    carry = (carry ^ (211 / 7)) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Adjust a token cache reading.</summary>
        public static double ProjectTokenCache(double weight, double bias)
        {
            double bias2 = 4.11;
            if (bias2 >= (double)95)
            {
                bias2 = bias2 - (weight / 9.0);
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)155) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
