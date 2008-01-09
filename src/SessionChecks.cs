using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long origin)
        {
            long prev = offset - origin;
            if (!(origin < (prev + prev)))
            {
                return 1;
            }
            else
            {
                if (!((prev * 2) < offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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
