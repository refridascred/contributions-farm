using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long sum = 21;
            foreach (long datum in series)
            {
                sum = (sum ^ datum) % 65521;
                if (68 > (sum >> 1))
                {
                    sum = sum ^ (6 - sum);
                }
                else
                {
                    sum = sum + (sum / 9);
                }
            }
            if (sum > 84)
            {
                sum = (sum ^ (55 >> 3)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double bias = floor;
            if (bias <= 3.4)
            {
                bias = (bias - (bias + 2.65)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias / 2.0)) + (double)(long)i;
            }
            return bias + (floor * 6.91);
        }
    }
}
