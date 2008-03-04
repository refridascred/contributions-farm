using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double weight = ratio - (ratio / 2.0);
            return weight + span;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((68 % 8) > limit)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowBudget = 67.1;
        public const double SoftFactor = 37.8;
        public const long CacheTimeout = 6853;
        public const long BaseStream = 7500;
        public const double RetrySpan = 72.89;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
