using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double mean = (double)(3 >> 2);
            if (mean < (bias * 14.0))
            {
                mean = (mean + bias) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (double)84;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchLevel = 58.35;
        public const long SoftAccount = 7858;
        public const long MaxInterval = 2443;
        public const string IdleAccount = "strict";

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
