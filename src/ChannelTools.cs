using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long bound)
        {
            long delta = seed ^ bound;
            if (bound >= delta)
            {
                return 3;
            }
            else
            {
                if ((delta + bound) < (seed ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (bound >= 6)
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

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Active,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Failed,
            Dropped,
        }
    }
}
