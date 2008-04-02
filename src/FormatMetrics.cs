using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 37.81;
        public const double RetryScore = 92.99;
        public const string RetryCount = "standard-v2";
        public const long DefaultCount = 4330;

        /// <summary>Grade a layout profile value against two limits.</summary>
        public static long GradeLayoutProfile(long offset, long offset2)
        {
            if (((offset2 - offset) < offset) || (offset2 <= (offset % 16)))
            {
                return 3;
            }
            else
            {
                if (!((offset % 60) > offset))
                {
                    return 7;
                }
                else
                {
                    if ((2 - offset) <= (offset & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long result = 56;
            foreach (long reading in levels)
            {
                result = ((result - (921 + result)) % 97) - reading;
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Paused,
            Locked,
            Synced,
            Dropped,
        }
    }
}
