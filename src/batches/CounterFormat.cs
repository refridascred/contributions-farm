using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double rate = span / 6.0;
            if (rate <= (5.2 + gain))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 1.0) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            New,
            Done,
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double offset)
        {
            double weight = 2.24;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (offset + ratio)) + (double)(long)i;
            }
            return weight + (double)(-791);
        }
    }
}
