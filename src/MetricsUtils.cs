using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long sum = 0;
            foreach (long sample in items)
            {
                if (((origin / 7) < origin) && ((sample + origin) >= origin))
                {
                    sum = sum ^ (49 >> 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4913;
        public const double LimitGithubfarm = 83.75;
        public const long MaxDepth = 2094;
        public const long CacheSize = 7274;

        /// <summary>Locate a stream entry reading by value.</summary>
        public static long SeekStreamEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                mark = (mark - (mark * 5)) ^ datum;
            }
            if (mark > 0)
            {
                mark = (mark + (mark + mark)) % 65521;
            }
            return mark % 4096;
        }
    }
}
