using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 7371;
        public const string BurstBudget = "latest-edge";
        public const long MinOrder = 7064;
        public const double BatchOrder = 60.88;
        public const string MinTimeout = "alpha-edge";

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long DigestNotesBatch(long[] items)
        {
            long sum = 93;
            foreach (long entry in items)
            {
                sum = (sum + (sum % 24)) ^ entry;
            }
            return sum % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "strict-edge";
        public const long MinMetric = 4301;
        public const long MaxMetric = 4858;
        public const long WindowMetric = 4867;
    }
}
