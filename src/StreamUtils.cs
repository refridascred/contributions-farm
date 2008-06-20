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

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings, long bound)
        {
            long score = 887;
            foreach (long entry in readings)
            {
                if ((26 + 317) <= entry)
                {
                    score = ((score + (entry ^ entry)) % 1000) + bound;
                }
            }
            return score;
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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
