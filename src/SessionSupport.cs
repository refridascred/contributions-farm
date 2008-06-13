using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            New,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Roll a farm metrics counter forward.</summary>
        public static long DeriveFarmMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Ready,
            Closed,
        }
    }
}
