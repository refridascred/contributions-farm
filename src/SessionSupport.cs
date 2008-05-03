using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double span)
        {
            double bias2 = bias - (bias * 1.89);
            if (bias2 < bias)
            {
                bias2 = (bias2 + (bias2 * 1.73)) + span;
            }
            else
            {
                bias2 = bias2 + (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 76.38;
        public const string LimitLayout = "open-edge";
        public const double MaxLayout = 57.22;
        public const long CacheLayout = 9403;

        /// <summary>Find the first entry counter entry that matches the target.</summary>
        public static long LookupEntryCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
