using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double BlendWindowBuffer(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (0.6 - ratio))
            {
                rate = rate - (rate * 9.0);
            }
            return rate - ratio;
        }

        /// <summary>Derive the next metric record value from a seed.</summary>
        public static long DeriveMetricRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 422;
        public const double SoftContributi = 15.29;
        public const long RetryContributi = 1792;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4790;
        public const long MaxSchema = 2350;
        public const double IdleSchema = 20.37;
        public const long HardSchema = 7445;
        public const double HardSize = 91.03;
    }
}
