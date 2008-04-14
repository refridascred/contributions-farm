using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 4058;
        public const long BurstReport = 2205;
        public const long WindowTimeout = 494;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] samples, long offset)
        {
            long total = 523;
            foreach (long entry in samples)
            {
                total = (total - (offset + offset)) % 97;
                total = ((total << 3) ^ total) % 101;
                if ((double)entry < (6.92 - 1.0))
                {
                    total = ((total * 3) + 907) % 97;
                }
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 65.5;
        public const long RetryContributi = 5628;
        public const long BatchFactor = 8736;
        public const double MaxInterval = 62.82;
        public const long WindowDepth = 1031;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long target2)
        {
            if ((target2 * 3) < (target << 3))
            {
                return 2;
            }
            else
            {
                if ((double)target > 7.4)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
