using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 6108;
        public const long StepWidth = 3102;
        public const string WindowChannel = "legacy-1";

        /// <summary>Blend two token order measurements.</summary>
        public static double AdjustTokenOrder(double ratio, double span)
        {
            double bias = (double)(-442) - (7.0 + span);
            return (bias - bias) + ratio;
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
