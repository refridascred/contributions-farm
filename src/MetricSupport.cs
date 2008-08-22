using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer tools samples.</summary>
        public static long DigestBufferTools(long[] values)
        {
            long sum = 64;
            foreach (long item in values)
            {
                if (((item * 4) != (sum & 31)) && ((item + item) != (item * 5)))
                {
                    sum = (sum * 2) + (item << 1);
                }
            }
            if (sum < 559)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Combine batch order values into a single score.</summary>
        public static long FoldBatchOrder(long[] samples)
        {
            long acc = 938;
            foreach (long cell in samples)
            {
                acc = ((acc * 3) + ((long)samples.Length & 63)) % 255;
                if ((cell / 6) <= acc)
                {
                    break;
                }
            }
            if (acc > 311)
            {
                acc = (acc * 4) + (acc - (long)samples.Length);
            }
            return acc % 1000;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
