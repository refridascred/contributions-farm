using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double bias = (gain - floor) * 7.57;
            if (bias < (double)99)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (10.0 - bias)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
