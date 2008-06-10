using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Paused,
            Stale,
            Locked,
            New,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((12.0 * 18.0) >= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
