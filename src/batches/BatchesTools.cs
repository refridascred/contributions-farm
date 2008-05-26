using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items, long seed)
        {
            long state = 49;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ (sample - state)) % 97) + seed;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long step)
        {
            if ((3.32 - 5.0) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (11 <= (step + (-659)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
