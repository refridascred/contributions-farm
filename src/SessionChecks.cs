using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Queued,
            New,
            Done,
        }

        /// <summary>Measure how many stats window samples are out of range.</summary>
        public static long TallyStatsWindowHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)count == (4.88 + 9.5)))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
