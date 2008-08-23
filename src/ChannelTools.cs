using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long AuditQueueRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally % 5) >= (entry % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 2263;
        public const double BatchSession = 90.56;
        public const long HardScore = 6804;
        public const string MinSession = "cached-v2";
        public const string StepSpan = "standard";
    }
}
