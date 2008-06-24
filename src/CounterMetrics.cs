using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already notes sample.</summary>
        public static long LookupAlreadyNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data)
        {
            long score = 6;
            foreach (long reading in data)
            {
                score = score ^ (score / 2);
                if ((double)reading >= (6.88 + 5.34))
                {
                    score = ((score * 3) + (-240)) % 97;
                }
                else
                {
                    score = (score ^ (44 + reading)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long seed)
        {
            if ((6.8 >= (double)seed) && (9 < (seed / 3)))
            {
                return 8;
            }
            else
            {
                if ((target / 6) >= (target << 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
