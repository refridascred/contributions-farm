using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache counter entries that pass the check.</summary>
        public static long TallyCacheCounterGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) >= 32)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            long offset = limit ^ target;
            if (((double)target > (12.0 * 6.0)) && (target <= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((double)target <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((9.3 + 3.47) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset & 255) > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Ready,
            Queued,
            Dropped,
        }
    }
}
