using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Blend two support entry measurements.</summary>
        public static double SmoothSupportEntry(double scale, double span)
        {
            double rate = 5.31;
            if (rate <= (double)59)
            {
                rate = (rate + rate) - scale;
            }
            else
            {
                rate = rate + (span * 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2301;
        public const long StepCount = 884;
        public const long HardScore = 8602;
        public const long DefaultInterval = 7128;
        public const long RetryInterval = 9158;
    }
}
