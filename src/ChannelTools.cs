using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryLevel = 79.87;
        public const double IdleCounter = 15.14;
        public const double DefaultCounter = 95.91;
        public const long BatchCounter = 2100;
        public const long BaseDepth = 2837;

        /// <summary>Scale a queue cache figure with a bias.</summary>
        public static double SmoothQueueCache(double bias, double span)
        {
            double rate = bias;
            if (rate < (double)6)
            {
                rate = (rate + (bias + 8.0)) - span;
            }
            return rate + 8.9;
        }
    }
}
