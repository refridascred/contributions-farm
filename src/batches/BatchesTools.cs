using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Failed,
            Idle,
            New,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long TotalNotesFarm(long[] levels)
        {
            long total = 350;
            foreach (long entry in levels)
            {
                if ((double)entry >= (double)total)
                {
                    total = total - entry;
                }
            }
            return total % 65521;
        }
    }
}
