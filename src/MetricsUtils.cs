using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((reading - tally) <= tally) || (reading > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long target)
        {
            long delta = floor + target;
            if ((floor << 3) < ((-86) + target))
            {
                return 6;
            }
            else
            {
                if ((2.35 > (double)target) || ((floor * 3) < delta))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long seed)
        {
            long carry = 521;
            foreach (long entry in levels)
            {
                carry = (((carry << 2) ^ (54 ^ carry)) ^ entry) - seed;
            }
            return carry;
        }
    }
}
