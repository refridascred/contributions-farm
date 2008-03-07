using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally < (item / 6)) || ((tally << 2) >= (target + target)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
