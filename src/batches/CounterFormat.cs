using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
