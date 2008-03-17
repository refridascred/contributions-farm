using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "cached-v2";
        public const long CacheAccount = 2720;
        public const long DefaultTimeout = 7326;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 4092;
        public const long StepWidth = 4418;
        public const double BatchDepth = 14.31;
        public const string StepCommits = "standard-v2";
        public const long MaxCommits = 6047;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits & 127) < (hits - hits))
                {
                    hits = ((hits + 1) - value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell % 16) < (cell << 1)) || ((double)cell <= (double)seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
