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

        /// <summary>Grade a schema checks value against two limits.</summary>
        public static long ClassifySchemaChecks(long offset, long offset2)
        {
            if (offset > (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((offset * 4) >= (offset - offset))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
