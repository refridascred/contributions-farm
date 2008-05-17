using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxCount = 8151;
        public const double IdleTimeout = 28.32;
        public const long SoftTimeout = 749;
        public const long RetryScore = 6038;
        public const long StepAccount = 7916;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (limit % 10);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
