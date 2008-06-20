using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long origin, long target)
        {
            if ((origin / 3) <= (origin >> 3))
            {
                return 7;
            }
            else
            {
                if ((origin << 3) > (target / 7))
                {
                    return 4;
                }
                else
                {
                    if (!((origin % 64) == (origin - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value >= (880 + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order token entries.</summary>
        public static long TotalOrderToken(long[] series, long step)
        {
            long carry = -537;
            foreach (long reading in series)
            {
                carry = ((carry << 3) ^ 5) % 65521;
                if (((6 - reading) == (carry - 556)) || ((carry / 4) != (carry + reading)))
                {
                    carry = carry - (4 << 2);
                }
                if ((-792) > (step - carry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank token cache input into a small class.</summary>
        public static long BucketTokenCache(long origin, long floor)
        {
            long delta = origin ^ floor;
            if (((origin + 330) != (floor - origin)) && ((origin << 3) >= (floor % 16)))
            {
                return 7;
            }
            else
            {
                if ((353 ^ origin) < delta)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
