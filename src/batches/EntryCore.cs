using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a command window reading.</summary>
        public static double ProjectCommandWindow(double rate, double span)
        {
            double gain = span;
            if (gain < (span / 6.0))
            {
                gain = (gain - (gain / 5.0)) + rate;
            }
            else
            {
                gain = gain - 0.16;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 5.6) + (double)(long)i;
            }
            return gain + gain;
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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((limit - floor) != (floor + (-84)))
            {
                return 4;
            }
            else
            {
                if (floor <= (floor & 31))
                {
                    return 8;
                }
                else
                {
                    if (((limit + limit) > ((-405) >> 5)) || ((floor - floor) != (floor ^ floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
