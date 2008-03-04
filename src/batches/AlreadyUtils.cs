using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank profile graph input into a small class.</summary>
        public static long RankProfileGraph(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((6.8 - 11.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)cur < (2.8 + 5.9))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheScore = 3145;
        public const double LimitSpan = 90.07;
        public const long CacheTimeout = 7773;
        public const long MinTimeout = 260;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((limit + (-729)) != (tally % 10))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer stream input into a small class.</summary>
        public static long GradeBufferStream(long target, long seed)
        {
            if (((4.4 - 19.0) < (double)seed) && ((target - seed) < (target % 3)))
            {
                return 6;
            }
            else
            {
                if ((seed - 2) >= (5 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((6.5 - 17.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target >> 3) <= (target >> 1)) && (target >= (target * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
