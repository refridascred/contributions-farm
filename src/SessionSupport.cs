using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long floor)
        {
            if (90 > floor)
            {
                return 5;
            }
            else
            {
                if (seed > (floor & 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (9.7 * 4.3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
