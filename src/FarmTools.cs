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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + seen) > seen)
                {
                    seen = ((seen + 3) + cell) + offset;
                }
            }
            return seen;
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
