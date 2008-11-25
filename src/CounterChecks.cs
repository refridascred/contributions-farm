using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long RankCounterLayout(long bound, long limit)
        {
            long offset = bound - limit;
            if ((2 & 7) != (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) == (limit >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 4) <= ((-379) & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit != (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long result = 9;
            foreach (long item in levels)
            {
                if (((8.05 / 6.0) < (double)result) && ((result + item) < (result + 41)))
                {
                    result = (result - (result % 3)) % 65521;
                }
                else
                {
                    result = ((result * 4) + (result ^ 33)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (limit > (limit - reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            New,
            Paused,
            Retry,
        }
    }
}
