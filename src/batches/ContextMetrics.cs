using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 3300;
        public const double DefaultContributi = 16.71;
        public const double LimitContributi = 46.71;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long offset)
        {
            long cur = bound - offset;
            if (!((double)cur >= (double)offset))
            {
                return 7;
            }
            else
            {
                if ((5.8 + 1.58) < (double)cur)
                {
                    return 0;
                }
                else
                {
                    if (!(cur <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4 >= (cur & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches >= (matches & 3)) || ((183 + matches) <= (sample * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((84 + tally) <= (tally << 1)) && (cell <= (tally / 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
