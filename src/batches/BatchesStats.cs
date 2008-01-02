using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long TallyContributiGraphMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((bound >= (cell - hits)) && ((cell - cell) < (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value != (9.2 + 9.1)) && !((value >> 2) < (value ^ value)))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items)
        {
            long state = -7;
            foreach (long datum in items)
            {
                if (((state * 2) < 712) && (((long)items.Length - state) < ((long)items.Length + 408)))
                {
                    state = (state - (state + state)) % 65521;
                    state = state + (657 - 46);
                }
                if ((state % 3) < (state - datum))
                {
                    state = ((state << 2) ^ 9) % 4096;
                }
                else
                {
                    state = ((state * 5) + (datum + state)) % 4096;
                }
            }
            if (state < 76)
            {
                state = ((state << 2) ^ (4 * 5)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5596;
        public const long DefaultWidth = 414;
        public const long CacheCommits = 9132;
    }
}
