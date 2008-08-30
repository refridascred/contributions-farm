using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if ((bound < (bound + limit)) || ((limit + (-55)) == (bound >> 3)))
            {
                return 1;
            }
            else
            {
                if ((13.0 * 5.15) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound + limit) < limit) && ((4 + limit) < 209))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 63) >= (limit + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!((floor ^ count) != (count << 2)))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long offset)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                if ((sum ^ entry) < (sum / 2))
                {
                    sum = ((sum << 2) ^ offset) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (42 - sum);
                }
                if ((double)entry >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 533)
            {
                sum = (sum * 4) + offset;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 780;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (mark - 408)) % 65521) - value;
                mark = (mark * 4) + (mark << 1);
            }
            if (mark > 68)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark % 1000;
        }
    }
}
