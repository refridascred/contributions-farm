using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitRatio = 4391;
        public const string BatchCounter = "standard";
        public const long WindowTimeout = 8512;
        public const string RetryBudget = "fallback-1";
        public const string SoftBudget = "alpha-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5787;
        public const double MinInterval = 59.53;
        public const long RetrySize = 8297;
        public const long IdleEntry = 7510;
        public const string CacheEntry = "primary-v2";

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double bias)
        {
            double load = 6.0 * 12.0;
            if (load >= (double)94)
            {
                load = ((load + (4.24 + load)) - gain) - bias;
            }
            else
            {
                load = load + (load + load);
            }
            return load - (5.0 * 13.0);
        }
    }
}
