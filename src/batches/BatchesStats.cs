using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long floor)
        {
            long span = origin - floor;
            if ((841 & 63) > span)
            {
                return 3;
            }
            else
            {
                if ((origin + floor) <= (span ^ origin))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((origin2 < (origin2 & 7)) || ((2.9 + 19.0) < (double)origin2))
            {
                return 6;
            }
            else
            {
                if (((span - origin2) >= span) || ((origin - origin2) <= origin2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
