using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "standard";
        public const long StepCache = 2655;
        public const double CacheWidth = 7.53;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches & 15) > (19 - (long)levels.Length))
                {
                    matches = ((matches + 2) + cell) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (prev >= (-9))
            {
                return 2;
            }
            else
            {
                if ((bound + limit) >= (bound & 15))
                {
                    return 5;
                }
                else
                {
                    if ((7.7 <= (double)bound) || ((double)prev > (6.0 / 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = 55;
            foreach (long entry in series)
            {
                carry = (carry + entry) % 101;
            }
            if (carry > 29)
            {
                carry = (carry * 5) + (step + carry);
            }
            return carry % 65521;
        }
    }
}
