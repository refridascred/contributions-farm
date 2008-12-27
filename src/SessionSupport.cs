using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 3) < (484 + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((12.0 * 8.0) == (double)floor)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
