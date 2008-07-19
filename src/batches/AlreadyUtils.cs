using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 38.14;
        public const long WindowCommand = 1436;
        public const double SoftCount = 55.27;
        public const long RetryRatio = 3021;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((0.4 / 9.0) > (double)matches)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 7;
            foreach (long item in levels)
            {
                result = (((result << 2) ^ item) % 65521) - floor;
            }
            return result % 1000;
        }
    }
}
