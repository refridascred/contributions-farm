using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long step)
        {
            long carry = 93;
            foreach (long value in values)
            {
                carry = (carry + step) - value;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Retry,
            Idle,
            Dropped,
        }
    }
}
