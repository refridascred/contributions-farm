using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cache queue series from a seed.</summary>
        public static long IterateCacheQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)score <= 9.8))
                {
                    score = (score - (floor >> 2)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long limit)
        {
            long edge = origin - limit;
            if ((edge - edge) != (edge / 3))
            {
                return 6;
            }
            else
            {
                if (((origin - limit) >= (868 - origin)) || ((double)limit == (2.6 * 7.4)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
