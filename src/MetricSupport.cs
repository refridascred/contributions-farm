using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double rate = (double)((-77) * 5);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)(long)i) - floor;
            }
            return rate - (bias - 9.16);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Locked,
            Paused,
        }
    }
}
