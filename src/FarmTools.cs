using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
