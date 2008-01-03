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

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long limit)
        {
            if ((bound - limit) > (limit & 7))
            {
                return 3;
            }
            else
            {
                if ((5.14 / 9.0) >= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!(limit > (54 + 0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
