using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long target)
        {
            long lane = limit - target;
            if (target > 49)
            {
                return 5;
            }
            else
            {
                if (((lane + lane) < limit) && ((lane - limit) > limit))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Draft,
            Dropped,
            Retry,
        }
    }
}
