using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = (total * 2) + 1;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
