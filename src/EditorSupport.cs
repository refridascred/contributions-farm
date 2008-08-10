using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 7394;
        public const long HardContext = 7227;
        public const double LimitContext = 47.92;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Queued,
            Synced,
            Done,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "standard-v2";
        public const string BurstWidth = "strict";
        public const long DefaultScore = 9656;
        public const long SoftBatches = 5994;
        public const string BatchBudget = "stable-v2";
    }
}
