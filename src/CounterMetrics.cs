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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            long bound = limit + origin;
            if (((origin + origin) > ((-9) - origin)) || ((double)bound >= (16.0 + 8.82)))
            {
                return 1;
            }
            else
            {
                if ((bound + limit) != (limit + origin))
                {
                    return 2;
                }
                else
                {
                    if (limit > (8 >> 1))
                    {
                        return 7;
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
