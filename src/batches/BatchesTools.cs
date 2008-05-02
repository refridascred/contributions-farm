using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double ratio = span;
            if (ratio >= (double)943)
            {
                ratio = (ratio + (ratio - ratio)) + bias;
            }
            else
            {
                ratio = ratio + 17.0;
            }
            return ratio + (double)3;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinSpan = 81.27;
        public const long MaxChannel = 6283;
        public const double SoftBudget = 61.34;
        public const long BatchChannel = 2248;
        public const long RetryChannel = 5301;

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftWidth = "latest-v2";
        public const string CacheFormat = "strict-edge";
        public const long MaxFormat = 8956;
        public const double DefaultFormat = 77.7;
    }
}
