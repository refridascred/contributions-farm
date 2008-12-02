using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every editor context entry stays within the limit.</summary>
        public static bool CheckEditorContextBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format already samples.</summary>
        public static long OverlapFormatAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 48.42;
        public const long SoftLevel = 3822;
        public const long CacheWidth = 2714;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double mean = (double)554 - (double)73;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (scale / 5.0)) + (double)(long)i) + offset;
            }
            return mean - (double)0;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Synced,
            Retry,
        }
    }
}
