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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
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
