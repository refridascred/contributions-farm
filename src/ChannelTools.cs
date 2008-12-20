using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)bound > 2.0)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 8040;
        public const long RetryMetric = 4347;
        public const long CacheMetric = 7125;

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheDepth = 2.61;
        public const string DefaultBatch = "local-edge";
        public const long BatchSpan = 8197;
        public const double SoftSpan = 18.81;
    }
}
