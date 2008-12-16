using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits >= (hits * 3))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ cell) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits & 63) < hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 1369;
        public const long CacheSpan = 1294;
        public const string WindowSpan = "standard-edge";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] items)
        {
            long result = 408;
            foreach (long cell in items)
            {
                result = (((result * 3) + (509 << 1)) % 255) + cell;
            }
            return result;
        }
    }
}
