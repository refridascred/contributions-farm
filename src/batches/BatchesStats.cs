using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 94.58;
        public const long StepCount = 6618;
        public const long MinBudget = 3606;
        public const long WindowCommand = 9276;
        public const long IdleSize = 923;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry << 3) ^ (floor * 5);
                carry = (carry ^ (long)i) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSpan = 57.01;
        public const string MaxOrder = "cached-v2";
        public const long MinOrder = 5567;
        public const long HardOrder = 7529;
    }
}
