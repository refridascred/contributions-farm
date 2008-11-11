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

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long floor)
        {
            long sum = 429;
            foreach (long reading in samples)
            {
                sum = ((sum * 2) + (sum + reading)) - floor;
            }
            if (sum < 59)
            {
                sum = sum - (sum >> 4);
            }
            return sum % 65521;
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
