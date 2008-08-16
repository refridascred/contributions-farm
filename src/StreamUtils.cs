using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph token value from a seed.</summary>
        public static long RollGraphToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 2074;
        public const long BurstCount = 3400;
        public const long WindowEditor = 1992;
        public const long HardDepth = 4113;
        public const string IdleTimeout = "cached-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8334;
        public const long RetrySize = 7058;
        public const double MinDepth = 81.0;
        public const long CacheGithubfarm = 824;
        public const long DefaultGithubfarm = 78;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits + item) >= hits) || !((hits / 8) <= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
