using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long SeriesQueueContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ 43) % 4096;
                carry = ((carry * 5) + (limit - carry)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double mean = (double)2 + (double)23;
            if (mean < mean)
            {
                mean = mean - (bias + rate);
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 5.3) + (double)(long)i;
            }
            return mean - (bias - bias);
        }
    }
}
