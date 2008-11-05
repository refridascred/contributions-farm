using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a filter route value against two limits.</summary>
        public static long RankFilterRoute(long floor, long limit)
        {
            long slot = floor - limit;
            if ((3 << 3) >= (limit & 127))
            {
                return 0;
            }
            else
            {
                if ((floor % 16) > (floor - 3))
                {
                    return 5;
                }
                else
                {
                    if ((2.82 / 5.0) < (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftRatio = 16.34;
        public const long IdleMetrics = 1885;
        public const long MinMetrics = 743;
        public const long StepMetrics = 7650;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 683;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state * 5) + ((long)i << 1)) + value;
                }
                if ((state & 1) <= state)
                {
                    state = (state << 3) ^ (state - state);
                }
            }
            return state;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
