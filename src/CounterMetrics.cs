using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 55.39;
        public const double DefaultAccount = 69.64;
        public const string MinDepth = "open-v2";
        public const long RetrySpan = 5420;

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double drift = (double)(987 >> 2);
            if (drift >= (rate + drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift - 7.71;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)326) + (double)(long)i;
            }
            return drift - (double)847;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Queued,
            Locked,
        }
    }
}
