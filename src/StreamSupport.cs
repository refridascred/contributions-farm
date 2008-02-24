using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long target)
        {
            if (8 <= (floor ^ target))
            {
                return 7;
            }
            else
            {
                if (target > floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)(-58) >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer farm readings.</summary>
        public static long TotalBufferFarm(long[] levels, long origin)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                if ((datum & 3) != (894 % 2))
                {
                    result = (((result << 3) ^ result) % 4096) - origin;
                }
                else
                {
                    result = (result - (19 + datum)) % 101;
                }
            }
            if (result > 695)
            {
                result = ((result << 2) ^ (90 ^ 46)) % 65521;
            }
            return result;
        }
    }
}
