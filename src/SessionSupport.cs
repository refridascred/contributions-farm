using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = ((mark << 2) ^ (floor + mark)) ^ entry;
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ ((-4) - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Audit context checks readings against a rule.</summary>
        public static long AuditContextChecksMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 3) < (0 - entry))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
