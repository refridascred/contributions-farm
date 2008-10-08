using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 83.84;
        public const string LimitQueue = "alpha-v2";
        public const long RetryQueue = 8364;
        public const long IdleSize = 9632;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)sample <= (double)limit) && ((limit << 1) <= (matches + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            long gap = offset + limit;
            if (((double)gap < (13.0 - 6.3)) && (offset > (gap + gap)))
            {
                return 7;
            }
            else
            {
                if ((2.48 * 5.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((offset / 4) > (offset % 2)) && ((gap % 7) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + offset) > offset) && (3.2 > (9.9 / 6.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
