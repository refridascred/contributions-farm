using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Active,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardWidth = 611;
        public const long StepSpan = 4969;
        public const long WindowLevel = 9833;
        public const long SoftTools = 5074;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
