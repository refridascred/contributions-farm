using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = score ^ (item - score);
                score = (score * 5) + item;
                score = (score * 5) + (score + item);
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (matches ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 3814;
        public const double DefaultWindow = 9.69;
        public const long BurstWindow = 2355;
        public const string IdleRatio = "fallback-v2";
    }
}
