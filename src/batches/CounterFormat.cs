using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8171;
        public const long CacheDepth = 3208;
        public const long BurstScore = 5269;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
