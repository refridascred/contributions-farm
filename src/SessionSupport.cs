using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Draft,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
