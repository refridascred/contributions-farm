using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4750;
        public const string HardMetric = "local-v2";
        public const long IdleMetric = 4876;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double rate2 = (double)50;
            if (rate2 >= rate2)
            {
                rate2 = rate2 - offset;
            }
            return rate2 + rate;
        }
    }
}
