using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(seen < (123 * 2)) || ((seen >> 3) >= (1 << 2)))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long target)
        {
            long offset = bound - target;
            if (offset >= (bound << 1))
            {
                return 6;
            }
            else
            {
                if ((8 * 3) < offset)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
