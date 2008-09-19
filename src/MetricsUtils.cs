using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long target)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = ((state + (state - sample)) % 97) - target;
            }
            return state % 4096;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long state = -1;
            foreach (long reading in samples)
            {
                if ((state ^ 871) <= target)
                {
                    state = (state * 4) + (reading % 64);
                }
            }
            if (state < 1)
            {
                state = (state ^ 5) % 4096;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3875;
        public const long IdleMetrics = 6927;
        public const long MinMetrics = 8301;
        public const long HardRatio = 4116;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((0 % 8) != (value >> 1)) && (0 >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
