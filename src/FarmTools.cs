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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark * 5) + ((long)i & 15);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
