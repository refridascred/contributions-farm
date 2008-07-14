using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((-11) <= (long)readings.Length)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Active,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 49.65;
        public const long DefaultSize = 4942;
        public const double DefaultReport = 96.21;
        public const double BaseCount = 4.96;
        public const long RetryReport = 3112;
    }
}
