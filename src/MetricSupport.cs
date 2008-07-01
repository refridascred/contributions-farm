using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next window token value.</summary>
        public static double SmoothWindowToken(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 >= bias2)
            {
                bias2 = bias2 + (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - offset) + (double)(long)i;
            }
            return bias2 - (offset + bias2);
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long IterateOrderMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long bound)
        {
            long carry = 376;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    break;
                }
                if ((bound ^ 39) <= cell)
                {
                    carry = (carry - (carry % 97)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (-1);
            }
            return carry;
        }
    }
}
