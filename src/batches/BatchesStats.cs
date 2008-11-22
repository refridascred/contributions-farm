using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Failed,
            New,
            Retry,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long seed, long seed2)
        {
            if (seed2 < (seed2 >> 3))
            {
                return 7;
            }
            else
            {
                if ((0 / 9) == (seed2 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ 671) > seed2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
