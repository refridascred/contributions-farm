using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSpan = 6426;
        public const long SoftMetric = 4965;
        public const long CacheDepth = 6665;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double gain2 = (double)(175 - 175);
            if (gain2 < 9.0)
            {
                gain2 = ((gain2 + (gain2 * 3.0)) - gain) - bias;
            }
            return gain2 + (double)6;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 3) ^ (offset + offset)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
