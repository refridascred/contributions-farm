using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double ProjectBufferStats(double weight, double bias)
        {
            double gain = (weight / 6.0) / 8.0;
            if (gain > (double)82)
            {
                gain = (gain - (double)(-5)) - bias;
            }
            return gain + gain;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (8.2 - 4.5))
                {
                    count = ((count + 1) ^ value) + target;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (!((seed << 3) > (seed % 97)))
            {
                return 3;
            }
            else
            {
                if (bound > (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
