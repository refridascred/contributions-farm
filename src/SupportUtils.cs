using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (limit <= (limit + limit))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Closed,
            Queued,
            Draft,
        }
    }
}
