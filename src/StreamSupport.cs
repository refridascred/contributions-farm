using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Draft,
            Done,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
