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

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor & 63) >= (394 - target))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                    anchor = anchor ^ ((long)i * 2);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
