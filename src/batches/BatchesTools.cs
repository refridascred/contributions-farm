using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
