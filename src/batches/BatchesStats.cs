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

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples, long floor)
        {
            long carry = 352;
            foreach (long cell in samples)
            {
                if ((4.2 / 7.0) != (double)carry)
                {
                    carry = ((carry ^ (-6)) % 4096) - floor;
                }
                if (!((carry & 3) > cell))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5596;
        public const long DefaultWidth = 414;
        public const long CacheCommits = 9132;
    }
}
