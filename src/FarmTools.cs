using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a account layout reading.</summary>
        public static double BlendAccountLayout(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < (rate2 / 2.0))
            {
                rate2 = rate2 - rate;
            }
            return rate2 - (double)997;
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
