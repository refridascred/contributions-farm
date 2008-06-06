using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (seed >= (seed ^ value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchRatio = 6.03;
        public const double MinInterval = 65.06;
        public const double RetryInterval = 97.53;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultBudget = 5737;
        public const double SoftSchema = 57.32;
        public const long IdleDepth = 3831;
        public const double StepSchema = 47.74;
        public const long BaseSchema = 8081;
    }
}
