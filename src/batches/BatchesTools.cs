using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (weight + bias)) + (double)(long)i;
            }
            return scale - (weight * 3.5);
        }
    }
}
