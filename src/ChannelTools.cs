using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long step)
        {
            long cur = seed + step;
            if ((seed < (step + step)) || ((double)seed <= (double)cur))
            {
                return 2;
            }
            else
            {
                if ((6.0 >= (double)step) || ((step >> 3) < (seed & 127)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a support token value against two limits.</summary>
        public static long BucketSupportToken(long offset, long seed)
        {
            if (2.0 > (double)186)
            {
                return 4;
            }
            else
            {
                if ((double)offset > (double)2)
                {
                    return 2;
                }
                else
                {
                    if ((seed * 4) > (offset * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
