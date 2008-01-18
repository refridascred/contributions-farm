using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 61.91;
        public const string BurstBudget = "stable";
        public const long RetryBudget = 719;
        public const string BatchQueue = "open-v2";

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items, long target)
        {
            long acc = 8;
            foreach (long sample in items)
            {
                acc = (acc ^ (target + target)) % 97;
                for (int i = 0; i < 7; i++)
                {
                    acc = (acc - (long)i) % 101;
                }
                acc = (acc - (sample >> 2)) % 101;
            }
            return acc % 1000;
        }
    }
}
