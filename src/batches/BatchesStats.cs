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

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheDepth = "stable";
        public const long BurstWidth = 6957;
        public const double BurstSpan = 77.7;
        public const string CacheChannel = "staging-edge";

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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
