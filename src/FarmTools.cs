using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Ready,
            Pending,
            Failed,
            Dropped,
        }
    }
}
