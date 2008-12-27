using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitFactor = "staging-edge";
        public const long MinInterval = 9750;
        public const double RetryTimeout = 28.78;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double load = (double)(4 + 108);
            return (load - (offset * 8.9)) + bias;
        }

        /// <summary>Roll a order window counter forward.</summary>
        public static long SeriesOrderWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 2) ^ (long)i;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
