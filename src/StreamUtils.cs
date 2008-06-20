using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long offset)
        {
            long offset2 = seed ^ offset;
            if (!(offset2 > (offset - seed)))
            {
                return 6;
            }
            else
            {
                if ((488 + seed) > (51 - 257))
                {
                    return 3;
                }
                else
                {
                    if (((seed ^ offset2) == (offset2 + seed)) && (offset2 < (offset2 + (-37))))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((score - (limit - 55)) % 97) - entry;
            }
            return score % 4096;
        }

        /// <summary>Accumulate counter token samples.</summary>
        public static long FoldCounterToken(long[] levels)
        {
            long anchor = -25;
            foreach (long cell in levels)
            {
                anchor = ((anchor + (anchor * 4)) % 4096) - cell;
            }
            if (anchor > 219)
            {
                anchor = anchor ^ (anchor >> 1);
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((long)levels.Length - hits) < (hits % 3)) || ((double)hits > (7.0 + 0.7)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                if (total > datum)
                {
                    total = (total << 3) ^ 35;
                }
            }
            return total;
        }
    }
}
