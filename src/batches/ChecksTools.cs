using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long seed)
        {
            if ((double)limit != (6.6 - 19.0))
            {
                return 2;
            }
            else
            {
                if (!((limit - limit) <= (limit % 8)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long GradeAlreadyReport(long seed, long bound)
        {
            long edge = seed + bound;
            if ((double)seed >= (double)edge)
            {
                return 0;
            }
            else
            {
                if ((bound & 3) >= (seed ^ bound))
                {
                    return 6;
                }
                else
                {
                    if (((140 + bound) >= edge) && ((edge & 63) != (edge - 27)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Failed,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 43.35;
        public const string BaseLevel = "alpha-edge";
        public const long CacheCluster = 4669;
        public const double SoftCluster = 74.99;
    }
}
