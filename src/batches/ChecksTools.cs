using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 8118;
        public const long CacheDepth = 1661;
        public const long HardTimeout = 2839;
        public const long WindowSupport = 4015;

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long total = 4;
            foreach (long datum in readings)
            {
                if ((double)total != (0.1 + 13.0))
                {
                    total = ((total * 5) + (datum << 2)) % 101;
                }
            }
            if (total > 98)
            {
                total = (total - (total << 2)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits << 3) == (item - hits)) || ((item + hits) != (item - 4)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
