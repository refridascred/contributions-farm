using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7348;
        public const string WindowWidth = "fallback-v2";
        public const long WindowSize = 4666;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 9203;
        public const long CacheEditor = 1197;
        public const long BurstEditor = 7342;

        /// <summary>Match up already stats samples.</summary>
        public static long MatchAlreadyStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstSpan = 54.34;
        public const long MaxInterval = 782;
        public const long WindowFilter = 5607;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count >> 2) > (value ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
