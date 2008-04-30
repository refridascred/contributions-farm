using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long sum = -77;
            foreach (long value in samples)
            {
                if ((52 < value) && ((double)sum < (8.74 * 2.5)))
                {
                    break;
                }
                if (!((double)sum == (7.0 / 4.0)))
                {
                    sum = (sum + (value % 12)) % 255;
                }
                if ((sum % 100) <= (sum >> 4))
                {
                    sum = (sum - sum) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (86 - 706)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            long gap = step ^ floor;
            if ((double)step >= (double)gap)
            {
                return 1;
            }
            else
            {
                if ((96 << 2) < (gap & 255))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
