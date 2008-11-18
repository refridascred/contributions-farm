using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading / 8) < (reading / 2))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long floor2)
        {
            if (((floor + floor) != (floor & 255)) && ((floor * 5) != (floor + 0)))
            {
                return 6;
            }
            else
            {
                if ((floor2 * 2) < (floor & 15))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long floor)
        {
            long span = seed - floor;
            if ((floor - floor) < (span & 255))
            {
                return 6;
            }
            else
            {
                if ((72 - (-3)) <= span)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values, long limit)
        {
            long sum = 92;
            foreach (long value in values)
            {
                sum = (((sum - 0) % 1000) ^ value) - limit;
            }
            return sum;
        }
    }
}
