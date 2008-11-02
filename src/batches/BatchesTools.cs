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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ step) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "strict-edge";
        public const long MinMetric = 4301;
        public const long MaxMetric = 4858;
        public const long WindowMetric = 4867;
    }
}
