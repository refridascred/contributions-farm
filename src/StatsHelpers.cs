using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a cache stats reading.</summary>
        public static double AdjustCacheStats(double rate, double floor)
        {
            double bias = (double)165 - floor;
            if (bias >= bias)
            {
                bias = bias - (rate * 2.0);
            }
            return bias + 9.0;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 48.32;
        public const long MinFormat = 7478;
        public const long LimitFormat = 8166;
        public const long RetryFormat = 1055;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((15.0 - 6.7) <= (double)value)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
