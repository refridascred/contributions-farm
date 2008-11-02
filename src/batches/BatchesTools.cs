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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "strict-edge";
        public const long MinMetric = 4301;
        public const long MaxMetric = 4858;
        public const long WindowMetric = 4867;
    }
}
