using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double bias2 = (bias + floor) * 12.0;
            if (bias2 >= (double)3)
            {
                bias2 = bias2 + floor;
            }
            return bias2 - floor;
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
