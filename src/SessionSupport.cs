using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Paused,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Synced,
            Queued,
            Ready,
        }
    }
}
