using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Locked,
            Pending,
        }
    }
}
