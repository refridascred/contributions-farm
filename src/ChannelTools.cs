using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Closed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if (limit2 > (limit - limit2))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) >= (limit2 - 31))
                {
                    return 5;
                }
                else
                {
                    if (limit < (limit2 - limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit != (8.3 / 3.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
