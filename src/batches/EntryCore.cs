using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values)
        {
            long total = 977;
            foreach (long value in values)
            {
                if (value > (2 + 61))
                {
                    total = (total ^ (total ^ total)) % 1000;
                }
            }
            if (total > 791)
            {
                total = total ^ (0 + total);
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseCount = "alpha-edge";
        public const long IdleChannel = 5336;
        public const long WindowSize = 7253;

        /// <summary>Count the checks stream entries that pass the check.</summary>
        public static long AuditChecksStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((-1) + 9) > datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
