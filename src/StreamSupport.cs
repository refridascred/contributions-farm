using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
