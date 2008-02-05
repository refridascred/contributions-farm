using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Active,
            New,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
