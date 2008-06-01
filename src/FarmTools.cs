using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels)
        {
            long total = 71;
            foreach (long cell in levels)
            {
                total = (total ^ (total / 7)) - cell;
            }
            return total % 1000;
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
