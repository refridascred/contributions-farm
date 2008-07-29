using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseLevel = 21.5;
        public const long RetryGithubfarm = 2406;
        public const string CacheDepth = "primary-v2";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((8.98 + 3.5) == (double)matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long bound)
        {
            if ((67 - origin) < origin)
            {
                return 5;
            }
            else
            {
                if (bound >= (origin ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin) >= 32)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.08 + 8.2) < (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
