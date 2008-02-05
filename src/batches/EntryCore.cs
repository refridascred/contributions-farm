using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long acc = 7;
            foreach (long sample in items)
            {
                acc = acc ^ (acc * 4);
                acc = acc - (sample + sample);
                if ((6.0 + 6.81) >= (double)sample)
                {
                    acc = (acc ^ (sample ^ acc)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseTimeout = 4261;
        public const string MaxGithubfarm = "strict";
        public const long BaseGithubfarm = 4760;
        public const long CacheRatio = 368;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (state - datum) % 255;
            }
            if (state > (-97))
            {
                state = (state - (7 >> 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((seed << 2) == (count + count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
