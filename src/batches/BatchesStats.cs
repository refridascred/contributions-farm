using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 19.12;
        public const long IdleDepth = 3446;
        public const string BatchBatches = "alpha-edge";
        public const long MaxDepth = 8622;
        public const double RetryFactor = 52.61;

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
