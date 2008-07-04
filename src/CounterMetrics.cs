using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSpan = 69.92;
        public const long HardWidth = 6145;
        public const long BaseBudget = 5722;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = sum ^ 62;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
