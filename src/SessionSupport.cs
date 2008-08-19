using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (6.9 >= (double)hits)
                {
                    hits = ((hits + 1) - item) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Queued,
            New,
            Draft,
        }
    }
}
