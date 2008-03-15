using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long seed)
        {
            long sum = 20;
            foreach (long item in series)
            {
                sum = (sum + (seed / 5)) % 255;
                sum = (sum << 3) ^ (item & 127);
                if ((4.26 <= (double)seed) || ((item + sum) <= (sum * 3)))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum + (seed + 228)) % 97;
            }
            return sum;
        }

        /// <summary>Scale a queue context figure with a bias.</summary>
        public static double SmoothQueueContext(double bias, double span)
        {
            double gain = 0.7 / 5.0;
            return ((gain - (9.74 * 0.62)) + bias) + span;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long WindowInterval = 5699;
        public const string LimitWindow = "staging-edge";
    }
}
