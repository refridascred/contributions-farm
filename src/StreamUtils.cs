using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long bound2)
        {
            if ((bound2 - bound2) > bound)
            {
                return 0;
            }
            else
            {
                if (!(bound2 < (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 << 2) < (bound + bound2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.3 / 9.0) >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "standard-v2";
        public const double WindowRecord = 78.08;
        public const double MinRecord = 53.5;
        public const long BaseSpan = 3216;
        public const double IdleRecord = 26.1;

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinScore = 20.16;
        public const double RetryNotes = 5.79;
        public const long LimitDepth = 6911;
        public const long BatchNotes = 9227;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Ready,
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 255) <= (852 ^ cell))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Paused,
            Pending,
        }
    }
}
