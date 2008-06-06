using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long target)
        {
            long state = -229;
            foreach (long datum in items)
            {
                if ((target & 31) == (0 + datum))
                {
                    state = ((state << 2) ^ (target >> 3)) % 97;
                }
                if (!((datum & 7) < (state << 2)))
                {
                    state = (state ^ (target - state)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
