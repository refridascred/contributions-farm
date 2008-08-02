using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series)
        {
            long state = 81;
            foreach (long item in series)
            {
                state = ((state << 2) ^ (state + 131)) + item;
            }
            if (state < (-815))
            {
                state = ((state * 4) + (state >> 5)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Pending,
            Ready,
            Draft,
            Active,
        }
    }
}
