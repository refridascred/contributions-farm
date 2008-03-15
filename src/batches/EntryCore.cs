using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 8587;
        public const long DefaultSupport = 5458;
        public const long IdleBudget = 7812;
        public const string HardInterval = "fallback-edge";
        public const long BurstSupport = 4895;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long origin)
        {
            long gap = limit - origin;
            if ((0 ^ origin) >= gap)
            {
                return 6;
            }
            else
            {
                if ((gap ^ origin) != (gap - origin))
                {
                    return 8;
                }
                else
                {
                    if ((16.0 * 8.72) < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 2) < (7 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
