using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long offset)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if (26 >= entry)
                {
                    total = (total << 2) ^ (total >> 1);
                }
                if ((entry <= (total + offset)) || ((offset - offset) != (145 / 8)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long limit)
        {
            long gap = step ^ limit;
            if ((gap + limit) > (12 - step))
            {
                return 7;
            }
            else
            {
                if ((12.0 + 9.39) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((11.0 - 5.42) < (double)gap)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((gap % 7) <= (gap << 1)) || ((step - (-31)) == (gap << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
