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

        /// <summary>Roll a layout tools counter forward.</summary>
        public static long IterateLayoutTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ (mix * 4)) % 1000;
                if ((offset & 31) <= (long)i)
                {
                    mix = (mix + ((long)i << 3)) % 101;
                }
                else
                {
                    mix = (mix ^ (offset + offset)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
