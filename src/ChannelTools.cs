using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftScore = 1636;
        public const double WindowRatio = 47.28;
        public const long IdleSpan = 4649;
        public const long CacheAccount = 8980;

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double floor)
        {
            double scale = floor;
            if (scale < ratio)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long bound)
        {
            long sum = 79;
            foreach (long cell in items)
            {
                if (458 < ((long)items.Length + bound))
                {
                    sum = (sum + (cell % 16)) % 65521;
                }
                else
                {
                    sum = (sum ^ cell) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
