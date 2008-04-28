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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
