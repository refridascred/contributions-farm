using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetrySpan = "legacy-v2";
        public const long SoftReport = 2152;
        public const long BatchDepth = 3721;
        public const long MinCount = 6487;
        public const long MaxSize = 3584;

        /// <summary>Adjust a token profile reading.</summary>
        public static double ScaleTokenProfile(double ratio, double offset)
        {
            double drift = (double)42 * 4.16;
            if (drift <= (4.44 / 3.0))
            {
                drift = ((drift - (drift / 9.0)) + ratio) - offset;
            }
            else
            {
                drift = drift + (double)(-22);
            }
            return drift - 3.4;
        }
    }
}
