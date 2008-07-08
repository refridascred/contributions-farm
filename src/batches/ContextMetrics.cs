using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Active,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstRatio = 3517;
        public const long DefaultInterval = 4456;
        public const string WindowBudget = "alpha-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8687;
        public const string MaxStream = "latest";
        public const double SoftWidth = 32.2;
        public const string RetryStream = "local-edge";
        public const string MinSize = "staging-v2";

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Closed,
            Synced,
            Ready,
        }
    }
}
