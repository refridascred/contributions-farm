using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double bias3 = (5.3 / 2.0) + (6.55 * 2.42);
            if (bias3 < bias)
            {
                bias3 = (bias3 + (bias + bias3)) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - 9.0) + (double)(long)i;
            }
            return bias3 + (5.4 * 2.0);
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Pending,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
