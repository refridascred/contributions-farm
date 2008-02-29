using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank tools route input into a small class.</summary>
        public static long RankToolsRoute(long floor, long seed)
        {
            long edge = floor ^ seed;
            if ((floor < (edge + edge)) && ((seed ^ 0) != (floor * 5)))
            {
                return 8;
            }
            else
            {
                if ((edge + floor) < 61)
                {
                    return 0;
                }
                else
                {
                    if (((edge >> 1) > 6) || ((floor * 3) >= 618))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 7) >= (edge % 16))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long step2)
        {
            if ((step ^ step2) >= (step2 >> 2))
            {
                return 6;
            }
            else
            {
                if ((4.0 * 8.1) > (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step2 ^ step) <= (918 ^ 613))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step > (7.3 * 7.23))
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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
