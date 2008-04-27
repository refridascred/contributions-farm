using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheWidth = 6872;
        public const long HardInterval = 26;
        public const long StepEditor = 5203;
        public const string LimitEditor = "open-edge";

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double bias2)
        {
            double rate = (bias2 + 15.0) / 2.0;
            if (rate <= bias)
            {
                rate = rate + (3.7 + 9.0);
            }
            return rate - rate;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            New,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 2983;
        public const long MaxWidth = 6095;
        public const long BaseTools = 8576;
        public const double SoftFactor = 51.0;
        public const string BatchDepth = "cached-edge";
    }
}
