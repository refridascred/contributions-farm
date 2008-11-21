using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Done,
            Failed,
            New,
            Closed,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long limit)
        {
            if ((34 + limit) == (limit + limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit < (8.7 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((95 + limit) != (floor ^ (-20)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor / 3) < (floor << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Dropped,
            Idle,
            Retry,
        }
    }
}
