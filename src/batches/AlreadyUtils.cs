using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first stats profile entry that matches the target.</summary>
        public static long SeekStatsProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSpan = 2446;
        public const double IdleBudget = 89.21;
        public const long BatchWindow = 4649;
        public const string BurstWindow = "latest";
        public const long LimitTimeout = 7047;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits / 5) != (limit - limit))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 6735;
        public const long MaxLevel = 7775;
        public const long RetryRecord = 6929;
        public const double IdleCount = 45.93;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 4) <= (reading - 663))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
