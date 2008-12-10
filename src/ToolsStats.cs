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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 58.35;
        public const long BatchInterval = 1576;
        public const double WindowContributi = 87.61;
        public const string BurstContributi = "latest-edge";

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                if (((16.0 - 3.29) >= (double)cell) || ((cell << 1) < (anchor - cell)))
                {
                    anchor = (anchor ^ 36) % 4096;
                }
                if (anchor >= (cell / 3))
                {
                    anchor = (anchor ^ (cell & 7)) % 4096;
                }
                if ((anchor + cell) < (cell & 127))
                {
                    anchor = (anchor ^ cell) % 4096;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor - (1 + anchor)) % 101;
            }
            return anchor;
        }
    }
}
