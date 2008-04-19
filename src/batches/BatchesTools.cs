using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < bias2)
            {
                mean = mean + bias;
            }
            return mean + (bias2 * 5.02);
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a buffer queue reading by value.</summary>
        public static long SeekBufferQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
