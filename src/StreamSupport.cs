using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "latest";
        public const double MinTimeout = 80.67;
        public const string LimitWidth = "legacy-1";

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double bias = (double)(9 << 2);
            if (bias <= (rate * 8.1))
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitRatio = 8.62;
        public const long RetryContributi = 1867;
        public const long CacheContributi = 8837;
        public const long BaseContributi = 562;
    }
}
