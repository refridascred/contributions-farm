using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5596;
        public const long BaseFormat = 1739;
        public const double BaseWidth = 34.38;
        public const long StepDepth = 8796;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
