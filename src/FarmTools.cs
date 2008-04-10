using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 9983;
        public const long RetryBudget = 8417;
        public const long HardFilter = 3452;
        public const long IdleFilter = 8632;
        public const long BurstSpan = 2128;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double gain = (double)(29 ^ 1);
            if (gain > gain)
            {
                gain = (gain - (bias / 9.0)) - ratio;
            }
            else
            {
                gain = gain - (gain * 5.0);
            }
            return gain + gain;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            New,
        }
    }
}
