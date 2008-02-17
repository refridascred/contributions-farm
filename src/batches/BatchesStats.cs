using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7356;
        public const double BurstStream = 28.23;
        public const double MinDepth = 89.89;
        public const string DefaultLevel = "strict-edge";

        /// <summary>Locate a editor command reading by value.</summary>
        public static long LookupEditorCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
