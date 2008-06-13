using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long origin)
        {
            long prev = step - origin;
            if (origin >= (prev / 3))
            {
                return 2;
            }
            else
            {
                if (3.62 <= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if (!((origin * 5) >= (origin / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((double)origin == (double)188)
            {
                return 8;
            }
            else
            {
                if (offset >= delta)
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) == (161 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank support session input into a small class.</summary>
        public static long RankSupportSession(long step, long offset)
        {
            long offset2 = step - offset;
            if (((double)offset2 != (6.11 - 5.5)) && (step <= offset))
            {
                return 2;
            }
            else
            {
                if ((235 ^ offset) >= (offset - offset2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)origin <= (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
