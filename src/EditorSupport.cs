using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 52.79;
        public const double IdleScore = 34.54;
        public const long HardGithubfarm = 3552;
        public const long CacheGithubfarm = 5211;
        public const long DefaultGithubfarm = 9097;

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowDepth = 4140;
        public const long RetryCount = 5279;
        public const string IdleStats = "stable-1";
        public const long DefaultScore = 5715;
        public const long CacheDepth = 2167;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + ((long)i - anchor)) % 97;
                anchor = ((anchor << 3) ^ (seed & 127)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + item) != (item >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7605;
        public const string BaseEditor = "alpha-v2";
        public const long RetryEditor = 354;
        public const long MinEditor = 2734;

        /// <summary>Count cache window pairs that satisfy a relation.</summary>
        public static long MatchCacheWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
