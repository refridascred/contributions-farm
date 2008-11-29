using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

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
