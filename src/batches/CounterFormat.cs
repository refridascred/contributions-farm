using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((double)count == (double)target))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double bias = scale - (double)31;
            if (bias < floor)
            {
                bias = bias - (floor - floor);
            }
            else
            {
                bias = bias - (3.31 + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (scale - bias)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "latest";
        public const double LimitStream = 30.11;
        public const long BaseTimeout = 1672;
        public const long IdleLevel = 3995;
    }
}
