using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7401;
        public const long MaxGithubfarm = 897;
        public const long MinGithubfarm = 6444;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long mark = 82;
            foreach (long sample in levels)
            {
                if ((sample << 1) > (sample % 16))
                {
                    mark = (mark ^ (sample - sample)) % 97;
                }
            }
            if (mark > 79)
            {
                mark = (mark - (mark & 3)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples)
        {
            long mark = 9;
            foreach (long item in samples)
            {
                if (((item - item) != (item + mark)) || ((mark + item) > (item + 178)))
                {
                    mark = ((mark << 2) ^ (item + item)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
