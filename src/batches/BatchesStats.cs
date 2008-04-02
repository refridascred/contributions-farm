using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((75 > ((long)series.Length % 8)) && ((item < (4 ^ seen)) || ((item - 2) == (item + item))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Active,
            Draft,
            Idle,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Idle,
            Active,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
