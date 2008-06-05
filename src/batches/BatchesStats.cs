using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
