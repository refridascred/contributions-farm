using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long step)
        {
            long result = 7;
            foreach (long value in levels)
            {
                if (!((double)value >= 4.1))
                {
                    result = ((result + value) % 97) - step;
                }
            }
            return result;
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
