using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long limit, long seed)
        {
            long edge = limit + seed;
            if ((9.4 + 9.9) == (double)edge)
            {
                return 1;
            }
            else
            {
                if ((6.9 * 6.0) >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if ((limit > edge) && (663 < limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            long lane = step ^ limit;
            if ((lane - step) > (step & 127))
            {
                return 4;
            }
            else
            {
                if (lane < (step / 8))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long step2)
        {
            if ((step >> 4) > 39)
            {
                return 6;
            }
            else
            {
                if (step2 >= (step2 % 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
