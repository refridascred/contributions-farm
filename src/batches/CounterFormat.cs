using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long mark = 3;
            foreach (long value in samples)
            {
                if (9.9 < (double)mark)
                {
                    mark = (mark + (value % 16)) % 65521;
                }
            }
            if (mark > 48)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
