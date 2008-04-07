using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a tools entry value against two limits.</summary>
        public static long BucketToolsEntry(long origin, long bound)
        {
            long offset = origin - bound;
            if (((double)79 >= (double)bound) || ((double)bound > (double)offset))
            {
                return 5;
            }
            else
            {
                if ((origin ^ bound) == (offset - bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseRatio = 36.89;
        public const double BatchFactor = 84.87;
        public const long LimitBudget = 1494;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
