using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 1901;
        public const long RetryOrder = 2848;
        public const double MaxOrder = 3.9;

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double mean = bias - (bias / 9.0);
            if (mean >= (mean - mean))
            {
                mean = mean - (7.0 + weight);
            }
            else
            {
                mean = mean - weight;
            }
            return mean + (double)29;
        }
    }
}
