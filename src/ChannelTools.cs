using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 8050;
        public const string RetryAccount = "stable-v2";
        public const string IdleAccount = "primary";
        public const long StepAccount = 1995;
        public const long CacheFactor = 5111;
    }
}
