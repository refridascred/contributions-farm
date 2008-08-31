using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long limit)
        {
            if ((6.1 - 13.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)6 == (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((double)reading >= (9.0 * 1.13)) && ((reading * 5) != (reading * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 7213;
        public const double IdleBudget = 94.42;
        public const double MaxSize = 91.46;
    }
}
