using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (carry >> 1)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long RankPayloadWindow(long seed, long floor)
        {
            long slot = seed + floor;
            if (9 <= floor)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= 7.0)
                {
                    return 0;
                }
                else
                {
                    if (((51 << 3) <= (slot + slot)) && (slot <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a token support counter forward.</summary>
        public static long IterateTokenSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed + mark) <= (seed * 3))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                if (((long)i - (long)i) <= ((long)i + mark))
                {
                    mark = ((mark * 2) + (0 % 2)) % 65521;
                }
                if (((1.6 - 6.0) >= (double)seed) && ((double)mark == (double)(-945)))
                {
                    mark = ((mark << 2) ^ ((long)i - seed)) % 1000;
                    mark = ((mark << 2) ^ mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long target)
        {
            long anchor = 65;
            foreach (long item in levels)
            {
                if ((anchor % 16) > (anchor + 712))
                {
                    anchor = (anchor ^ (anchor - item)) - target;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor >> 5)) % 4096;
                }
            }
            if (anchor > 79)
            {
                anchor = (anchor << 3) ^ (5 & 63);
            }
            return anchor;
        }
    }
}
