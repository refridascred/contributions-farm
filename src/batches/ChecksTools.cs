using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local-1";
        public const long RetryEntry = 6075;
        public const long CacheLevel = 8565;
        public const double LimitTimeout = 13.39;
        public const double BatchEntry = 98.71;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9572;
        public const double BurstRatio = 39.74;
        public const long WindowMetrics = 3321;
        public const string HardMetrics = "primary";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long seed, long origin)
        {
            if (seed >= (seed * 5))
            {
                return 7;
            }
            else
            {
                if ((double)seed == (8.62 / 8.0))
                {
                    return 3;
                }
                else
                {
                    if (1.24 > (double)seed)
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
}
