using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Draft,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Classify a context queue pair into a bucket.</summary>
        public static long GradeContextQueue(long limit, long offset)
        {
            if (((limit + limit) <= (466 - offset)) || (limit < (offset - offset)))
            {
                return 7;
            }
            else
            {
                if ((7.5 + 7.0) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (9 <= (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit >= 765)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a cluster cache reading.</summary>
        public static double ScaleClusterCache(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (double)(-34))
            {
                scale = (scale + scale) + span;
            }
            return scale - scale;
        }
    }
}
