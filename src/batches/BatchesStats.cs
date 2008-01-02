using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a githubfarm account counter forward.</summary>
        public static long DeriveGithubfarmAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value != (9.2 + 9.1)) && !((value >> 2) < (value ^ value)))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 20.7;
        public const string IdleBuffer = "latest-edge";
        public const long MinInterval = 8709;
        public const double HardBuffer = 71.37;
        public const long BurstBuffer = 299;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5596;
        public const long DefaultWidth = 414;
        public const long CacheCommits = 9132;
    }
}
