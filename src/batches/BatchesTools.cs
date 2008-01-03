using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels, long floor)
        {
            long sum = 759;
            foreach (long sample in levels)
            {
                sum = ((((sum << 3) ^ (sum << 1)) % 101) + sample) + floor;
            }
            return sum;
        }

        /// <summary>Count cache notes pairs that satisfy a relation.</summary>
        public static long MatchCacheNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
