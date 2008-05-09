using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryInterval = 91.35;
        public const long BatchScore = 5147;
        public const double StepLevel = 34.44;
        public const string SoftSize = "fallback-v2";
        public const string MinTimeout = "stable-edge";

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double mean = ratio + (double)5;
            if (mean <= (offset / 2.0))
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (mean * 5.0);
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
