using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultInterval = 13.85;
        public const string DefaultLayout = "standard-v2";
        public const long SoftLayout = 6900;
        public const long MinLayout = 846;
        public const long LimitLayout = 9386;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Closed,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Ready,
            New,
            Draft,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Idle,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 2) + state;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
