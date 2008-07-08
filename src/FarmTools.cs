using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long origin)
        {
            if (!((916 + step) <= step))
            {
                return 7;
            }
            else
            {
                if ((step & 31) > (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Done,
            Ready,
            Pending,
        }
    }
}
