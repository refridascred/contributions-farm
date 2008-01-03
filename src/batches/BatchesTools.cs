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

        /// <summary>Fold a list of counter token readings.</summary>
        public static long FoldCounterToken(long[] samples)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                sum = ((sum ^ sum) % 4096) + value;
            }
            return sum;
        }
    }
}
