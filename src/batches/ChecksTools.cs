using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 76.87;
        public const long RetryLevel = 4340;
        public const long BurstInterval = 1123;
        public const long MinTimeout = 6237;
        public const long BurstLevel = 8782;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (6.9 - 3.9))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
