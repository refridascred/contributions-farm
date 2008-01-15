using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSpan = 9167;
        public const double MaxOrder = 76.04;
        public const long WindowSize = 7591;
        public const long RetryLevel = 7861;
        public const string DefaultOrder = "cached-v2";

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double load = span;
            if (load <= span)
            {
                load = (load - (double)3) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (10.0 - 14.0)) + (double)(long)i;
            }
            return load + (double)257;
        }
    }
}
