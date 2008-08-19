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

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheBudget = 3407;
        public const string HardScore = "fallback-v2";
        public const long SoftBudget = 3939;
        public const string IdleFormat = "latest-v2";
        public const double MaxFormat = 53.0;
    }
}
