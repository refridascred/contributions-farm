using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long total = 73;
            foreach (long item in series)
            {
                if ((6 % 3) != (total & 31))
                {
                    total = ((total + (total & 15)) % 4096) - item;
                }
            }
            return total;
        }
    }
}
