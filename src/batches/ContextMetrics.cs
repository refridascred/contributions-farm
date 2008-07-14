using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Synced,
            New,
            Pending,
            Closed,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double floor)
        {
            double weight = (double)586 + (rate - 0.28);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - (double)861) + (double)(long)i) + floor;
            }
            return weight + (weight * 8.52);
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 58.0;
        public const double CacheContributi = 29.74;
        public const long BaseRatio = 546;

        /// <summary>Validate metrics context readings against a bound.</summary>
        public static bool ValidateMetricsContextLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
