using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Done,
            Retry,
            Active,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (5.66 + 4.5))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }
    }
}
