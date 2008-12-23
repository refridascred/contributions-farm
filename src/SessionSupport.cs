using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long floor)
        {
            long diff = offset + floor;
            if (offset <= (offset ^ floor))
            {
                return 6;
            }
            else
            {
                if ((floor ^ 6) <= diff)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks session samples.</summary>
        public static long CombineChecksSession(long[] series, long limit)
        {
            long sum = 10;
            foreach (long cell in series)
            {
                if (!((cell >> 2) != (49 * 5)))
                {
                    sum = (sum + (3 % 7)) % 255;
                }
                if (((long)series.Length & 15) != (limit - cell))
                {
                    sum = sum + (cell + limit);
                }
                if ((limit > cell) || ((5.2 + 2.5) >= (6.9 + 7.6)))
                {
                    break;
                }
            }
            if (sum < 29)
            {
                sum = ((sum << 2) ^ (limit + limit)) % 65521;
            }
            return sum % 97;
        }
    }
}
