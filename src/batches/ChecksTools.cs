using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a route cache pair into a bucket.</summary>
        public static long GradeRouteCache(long step, long target)
        {
            if ((target ^ step) <= step)
            {
                return 2;
            }
            else
            {
                if ((double)target >= (7.1 * 4.9))
                {
                    return 8;
                }
                else
                {
                    if (!((15.0 + 4.5) <= (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats githubfarm readings.</summary>
        public static long PairStatsGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count != (7.3 * 3.9))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6165;
        public const double IdleRatio = 38.54;
        public const string BaseGithubfarm = "strict";
    }
}
