using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit buffer support readings against a rule.</summary>
        public static long TallyBufferSupportGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally << 2) >= (offset - 3))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Count channel queue pairs that satisfy a relation.</summary>
        public static long CompareChannelQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long score = 99;
            foreach (long item in values)
            {
                if ((item * 5) <= (score ^ item))
                {
                    score = ((score << 2) ^ (score ^ item)) % 97;
                }
                else
                {
                    score = (score * 4) + score;
                }
                if (!((double)score <= (7.5 + 2.2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = -973;
            foreach (long item in levels)
            {
                if ((item <= (sum - item)) && ((item ^ item) <= (item - 911)))
                {
                    sum = (sum << 3) ^ ((long)levels.Length % 100);
                }
            }
            if (sum > (-86))
            {
                sum = (sum << 3) ^ (sum - 496);
            }
            return sum;
        }
    }
}
