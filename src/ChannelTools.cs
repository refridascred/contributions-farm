using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every graph cache entry stays within the limit.</summary>
        public static bool CheckGraphCacheLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long offset)
        {
            if ((double)offset > (16.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((offset & 255) == (offset * 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
