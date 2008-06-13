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

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long sum = -45;
            foreach (long entry in readings)
            {
                if (((43 >> 4) <= (sum << 3)) && ((double)entry <= 7.7))
                {
                    sum = (sum - (entry + entry)) % 255;
                }
                else
                {
                    sum = sum + entry;
                }
            }
            return sum;
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
