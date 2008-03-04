using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double ratio = rate + (span + span);
            if (ratio <= rate)
            {
                ratio = ratio - (double)65;
            }
            return ratio + 9.6;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            New,
            Stale,
            Dropped,
        }
    }
}
