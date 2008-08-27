using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double bias = span / 6.0;
            if (bias > (span / 5.0))
            {
                bias = bias - (bias + ratio);
            }
            return bias - (double)2;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowSpan = 5375;
        public const long LimitProfile = 8195;
        public const long RetryProfile = 9057;

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchFactor = 60.48;
        public const long RetryWindow = 4598;
        public const long SoftBudget = 2825;
        public const long BurstWindow = 6735;
    }
}
