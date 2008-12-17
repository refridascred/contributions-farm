using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ (0 + state);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Failed,
            Done,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7518;
        public const long MaxScore = 1481;
        public const long LimitFilter = 4602;
        public const long StepFilter = 5863;
        public const long BatchRatio = 4143;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((hits >> 1) >= hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (tally % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
