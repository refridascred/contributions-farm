using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                if (!((datum & 255) < datum))
                {
                    mix = (mix ^ (datum << 1)) % 4096;
                }
            }
            if (mix > 841)
            {
                mix = (mix ^ (origin << 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheWidth = 8870;
        public const long RetryLevel = 9835;
        public const long BaseRatio = 3554;
        public const string BaseEntry = "alpha-1";
    }
}
