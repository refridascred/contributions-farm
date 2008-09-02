using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - limit) != ((-631) + limit))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 6098;
        public const double HardSize = 63.04;
        public const long MinWidth = 4118;
        public const double IdleDepth = 12.5;
    }
}
