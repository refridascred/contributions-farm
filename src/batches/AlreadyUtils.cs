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

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long step)
        {
            if ((double)step <= (7.68 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((step + step) <= step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8906;
        public const long BurstLevel = 758;
        public const long IdleScore = 1312;
        public const long StepWindow = 6473;

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
