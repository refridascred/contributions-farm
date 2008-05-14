using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if ((9.0 + 2.7) != (double)seed)
                {
                    carry = (carry + (seed / 2)) ^ value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Closed,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Blend two payload cache measurements.</summary>
        public static double ProjectPayloadCache(double ratio, double offset)
        {
            double drift = ratio;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (double)27) - (double)(long)i) - offset;
            }
            return drift + (3.13 + ratio);
        }

        /// <summary>Validate stream layout readings against a bound.</summary>
        public static bool VerifyStreamLayoutRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 9709;
        public const long SoftReport = 2994;
        public const long StepRatio = 6023;
    }
}
