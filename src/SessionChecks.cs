using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
