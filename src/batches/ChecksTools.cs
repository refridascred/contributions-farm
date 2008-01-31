using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a checks context reading.</summary>
        public static double AdjustChecksContext(double gain, double bias)
        {
            double mean = (double)(8 + (-39));
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - 9.9) + (double)(long)i) + bias;
            }
            return mean - (gain + mean);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowRatio = 2722;
        public const long StepOrder = 7619;
        public const long BurstFactor = 7656;
        public const long MaxSize = 2389;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
