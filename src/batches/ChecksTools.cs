using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank filter record input into a small class.</summary>
        public static long ClassifyFilterRecord(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((0.5 - 1.0) == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound2 % 64) < (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 15) != (bound - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((6.5 / 9.0) < (double)floor)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 5498;
        public const long CacheMetrics = 8028;
        public const string CacheLevel = "legacy";
    }
}
