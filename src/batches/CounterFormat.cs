using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowDepth = 67.68;
        public const double BurstTimeout = 43.07;
        public const long CacheToken = 6276;
        public const long MaxToken = 4105;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double mean = gain;
            if (mean < (offset - mean))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean - 11.0;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
