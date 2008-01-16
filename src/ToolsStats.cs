using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (limit + sum);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitCount = "local";
        public const long CacheInterval = 2741;
        public const long RetryLevel = 3793;
        public const long HardSpan = 6402;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
