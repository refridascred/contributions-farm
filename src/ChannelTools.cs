using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Active,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((tally >> 1) >= (tally & 127)) || ((tally & 1) < (tally << 2))))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Pending,
            Locked,
        }
    }
}
