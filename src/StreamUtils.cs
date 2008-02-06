using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7347;
        public const long IdleGithubfarm = 2489;
        public const long CacheRatio = 1601;
        public const long SoftTimeout = 5568;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value != (double)766)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
