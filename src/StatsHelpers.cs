using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value - value) != (3 + value)) && ((double)seed != (0.66 - 8.14)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long carry = 2;
            foreach (long sample in series)
            {
                if (!((double)carry > (3.5 - 1.0)))
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
                if (((sample - sample) <= sample) || ((carry + (-4)) != (sample >> 3)))
                {
                    continue;
                }
                carry = (carry ^ (carry % 10)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long target, long origin)
        {
            if ((933 % 24) > target)
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (11.0 * 1.9)) || ((2.5 / 5.0) <= (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((target - origin) >= (origin & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
