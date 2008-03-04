using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
