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

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark + mark) % 255) ^ (long)i2;
                }
                if (((long)i == (limit << 1)) || ((limit % 8) > 8))
                {
                    continue;
                }
                else
                {
                    mark = mark + (mark - limit);
                }
                mark = (mark + (4 ^ limit)) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((5.3 + 2.8) != (double)seen))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
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
