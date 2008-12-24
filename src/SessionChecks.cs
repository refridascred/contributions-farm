using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a payload channel sample.</summary>
        public static long FindPayloadChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (limit >= (hits / 6))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 1.18)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
