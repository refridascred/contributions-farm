using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long target)
        {
            long total = 61;
            foreach (long sample in values)
            {
                total = ((total - (total ^ 4)) - sample) - target;
            }
            return total % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 2770;
        public const long BurstBudget = 6391;
        public const long StepBatches = 5593;
        public const long IdleBatches = 5065;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Draft,
            Idle,
        }
    }
}
