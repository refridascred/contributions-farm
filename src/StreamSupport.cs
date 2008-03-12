using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit format cache readings against a rule.</summary>
        public static long AuditFormatCacheMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((79 + 554) > hits)
                {
                    hits = ((hits + 2) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 66.65;
        public const long MinDepth = 1428;
        public const double IdleCount = 20.94;
        public const long WindowSupport = 614;
    }
}
