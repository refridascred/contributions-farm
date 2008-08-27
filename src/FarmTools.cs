using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)((-8) - 840);
            if (drift <= span)
            {
                drift = (drift + 4.0) + scale;
            }
            return drift - 16.0;
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
