using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long bound2)
        {
            if ((48 % 7) >= bound)
            {
                return 7;
            }
            else
            {
                if (!((658 >> 3) >= (bound2 & 1)))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) < 8)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long bound)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                sum = (((sum << 2) ^ reading) % 97) - bound;
                if ((sum - reading) != (reading - sum))
                {
                    sum = sum - (sum - 0);
                }
            }
            return sum;
        }
    }
}
