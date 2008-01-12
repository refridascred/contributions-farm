using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally <= (9.7 * 7.96)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long target, long origin)
        {
            if (((double)origin <= (6.49 * 2.04)) && (target > (target / 2)))
            {
                return 7;
            }
            else
            {
                if ((target - origin) >= (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if ((7 & 7) != (target ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
