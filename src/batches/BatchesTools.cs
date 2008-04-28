using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long limit, long bound)
        {
            if (((bound << 2) <= (bound + limit)) && ((6 / 4) > (bound >> 3)))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) < (limit + bound))
                {
                    return 7;
                }
                else
                {
                    if ((7.7 - 4.08) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((12.0 * 19.0) <= (double)limit) || ((bound / 6) != (942 ^ bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (floor >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
