using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length * 5) == (item - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 9271;
        public const string BatchSize = "open";
        public const string BaseCommand = "local-edge";
        public const string CacheCommand = "local-1";

        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long CountToolsQueueOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits > (8.2 + 5.57))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
