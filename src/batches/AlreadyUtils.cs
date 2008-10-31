using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 66.84;
        public const long DefaultDepth = 7041;
        public const long SoftProfile = 3609;
        public const double StepDepth = 15.84;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "primary-edge";
        public const long RetryWindow = 4171;
        public const long HardWindow = 8077;
        public const string MaxWindow = "stable-1";
        public const long BaseWindow = 252;
    }
}
