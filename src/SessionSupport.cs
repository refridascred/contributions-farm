using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits & 15) > (origin - origin)) || ((hits ^ 771) != (value % 16)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 5519;
        public const long LimitCache = 703;
        public const double RetrySize = 64.1;
    }
}
