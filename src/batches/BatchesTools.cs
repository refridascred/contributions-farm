using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = score - (score + 61);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultTimeout = 79.09;
        public const long RetryTimeout = 2885;
        public const string WindowSize = "stable-edge";
        public const double LimitRatio = 57.15;
    }
}
