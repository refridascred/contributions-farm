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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)carry < (double)(long)i))
                {
                    carry = (carry * 4) + limit;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
