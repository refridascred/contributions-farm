using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 94;
            foreach (long cell in samples)
            {
                total = (total - cell) % 97;
            }
            return total % 65521;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Audit layout route readings against a rule.</summary>
        public static long TallyLayoutRouteHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((0.5 / 5.0) <= (double)offset)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
