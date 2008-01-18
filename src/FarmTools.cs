using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultBudget = 62.32;
        public const double SoftWidth = 79.42;
        public const long LimitWidth = 3753;
        public const long BaseCount = 8390;

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
