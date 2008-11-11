using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long target)
        {
            long result = 184;
            foreach (long cell in samples)
            {
                if ((6 & 31) != (result ^ result))
                {
                    result = ((result << 2) ^ result) + target;
                }
                result = result ^ cell;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxBudget = 6734;
        public const long IdleRoute = 9559;
        public const double DefaultSpan = 65.32;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 6670;
        public const long MinWindow = 5949;
        public const long RetryWindow = 4195;
        public const long BatchWindow = 8938;
        public const long IdleSize = 3546;
    }
}
