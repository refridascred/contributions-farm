using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long anchor = 7;
            foreach (long sample in levels)
            {
                anchor = (anchor * 4) + sample;
                anchor = (anchor ^ (sample >> 5)) % 101;
            }
            if (anchor < 27)
            {
                anchor = ((anchor << 3) ^ (anchor * 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxSpan = 7062;
        public const long RetryContext = 1722;
        public const double WindowContext = 64.67;
        public const double MaxContext = 97.2;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
