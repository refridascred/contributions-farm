using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Stale,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long target)
        {
            long diff = bound - target;
            if (!((target % 64) >= bound))
            {
                return 3;
            }
            else
            {
                if ((target * 3) != (diff << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
