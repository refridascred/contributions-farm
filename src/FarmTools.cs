using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (127 > (step + 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings, long bound)
        {
            long carry = 986;
            foreach (long value in readings)
            {
                if (((double)carry == (6.79 * 1.9)) || ((value + value) >= (carry + bound)))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
            }
            if (carry < 23)
            {
                carry = ((carry * 5) + ((-67) & 31)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long limit)
        {
            if (((limit & 1) < origin) && (6 <= (origin - limit)))
            {
                return 7;
            }
            else
            {
                if (origin < 92)
                {
                    return 1;
                }
                else
                {
                    if ((origin + limit) < (5 * 5))
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
    }
}
