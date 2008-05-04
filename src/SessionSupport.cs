using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) <= (27 >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 76.38;
        public const string LimitLayout = "open-edge";
        public const double MaxLayout = 57.22;
        public const long CacheLayout = 9403;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Ready,
            Synced,
            Retry,
        }
    }
}
