using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 8;
            foreach (long reading in samples)
            {
                if ((5.0 * 8.07) >= (double)(long)samples.Length)
                {
                    score = ((score << 2) ^ (reading >> 2)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((2.4 * 6.67) >= (double)count) || ((bound << 2) <= (bound & 1)))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long offset)
        {
            long step = floor + offset;
            if ((step + 2) < (step ^ step))
            {
                return 5;
            }
            else
            {
                if ((4.59 + 1.6) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((1.8 - 15.0) <= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
