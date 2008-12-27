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

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double offset)
        {
            double weight = offset;
            if (weight >= rate)
            {
                weight = weight - 7.98;
            }
            else
            {
                weight = weight - (offset / 6.0);
            }
            return weight + (7.58 + weight);
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long seed)
        {
            if ((seed >> 5) < 672)
            {
                return 8;
            }
            else
            {
                if ((double)(-237) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
