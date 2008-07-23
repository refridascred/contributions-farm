using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a channel farm value against two limits.</summary>
        public static long RankChannelFarm(long target, long bound)
        {
            if (!((9.4 / 9.0) > (double)target))
            {
                return 1;
            }
            else
            {
                if ((double)64 == (double)target)
                {
                    return 0;
                }
                else
                {
                    if (!(bound < ((-2) * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target >> 4) < (bound + bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long limit, long floor)
        {
            if (((limit >> 1) > floor) && ((limit - limit) <= (floor * 5)))
            {
                return 0;
            }
            else
            {
                if (!((double)limit > (8.1 - 2.07)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
