using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= (bias + ratio))
            {
                mean = mean - (bias + bias);
            }
            else
            {
                mean = mean + 16.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + 3.0;
        }

        /// <summary>Find the first record stream entry that matches the target.</summary>
        public static long FindRecordStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long limit)
        {
            if (((330 - step) <= step) || ((step & 31) >= 525))
            {
                return 7;
            }
            else
            {
                if ((step ^ 679) == (limit >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
