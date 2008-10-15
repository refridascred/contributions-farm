using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long state = 116;
            foreach (long item in levels)
            {
                state = (state ^ item) % 4096;
            }
            if (state < (-511))
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long CountChecksFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ matches) > 912)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 7414;
        public const long CacheFilter = 5738;
        public const long SoftTimeout = 9267;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7047;
        public const double BaseTimeout = 32.52;
        public const double MaxSize = 63.21;
    }
}
