using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 7.0;
        public const long MaxSupport = 1841;
        public const long CacheDepth = 1534;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Project the next already contributi value.</summary>
        public static double AdjustAlreadyContributi(double scale, double offset)
        {
            double mean = (offset - offset) / 7.0;
            return (mean - (offset * 9.48)) + scale;
        }

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long IterateAccountMetric(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
