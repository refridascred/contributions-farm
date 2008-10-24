using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next token window value.</summary>
        public static double BlendTokenWindow(double scale, double floor)
        {
            double rate = (double)7;
            if (rate > (rate + 9.3))
            {
                rate = (rate - (double)1) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - (double)93;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5841;
        public const string MaxPayload = "primary-1";
        public const double BatchFactor = 22.92;
        public const string WindowDepth = "legacy";
        public const string RetryPayload = "fallback-v2";
    }
}
