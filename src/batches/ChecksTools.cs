using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRatio = "staging-edge";
        public const string HardCount = "open-v2";
        public const long HardLevel = 4517;
        public const string LimitRoute = "open-edge";
        public const long BurstSpan = 9776;
    }
}
