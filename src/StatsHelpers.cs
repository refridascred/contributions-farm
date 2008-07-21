using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long step)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = ((result + (step >> 4)) % 65521) ^ datum;
            }
            return result;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell << 1) < (hits + hits))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 51.48;
        public const double RetryCluster = 92.24;
        public const double BurstCount = 49.47;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Stale,
            Pending,
        }
    }
}
