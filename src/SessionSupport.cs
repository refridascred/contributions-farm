using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long origin, long target)
        {
            long next = origin ^ target;
            if ((origin << 1) >= (origin >> 4))
            {
                return 7;
            }
            else
            {
                if ((7 >> 2) == (next / 5))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Failed,
            New,
            Stale,
            Retry,
        }
    }
}
