using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen >= (2.6 / 7.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (5.7 / 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Closed,
            New,
            Pending,
            Stale,
        }
    }
}
