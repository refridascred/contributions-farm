using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches >= step)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series, long target)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                mark = mark - (mark % 2);
                if ((double)841 <= (double)cell)
                {
                    mark = (mark - (target + cell)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9.44 * 7.7) != (double)offset)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm account counter forward.</summary>
        public static long SeriesGithubfarmAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark * 2) + floor) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((matches >= (32 % 2)) || ((double)matches <= (double)sample)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
