using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            long slot = limit ^ bound;
            if ((5 + bound) >= (bound << 1))
            {
                return 4;
            }
            else
            {
                if (7.9 > (double)slot)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitFactor = 3931;
        public const long IdleCounter = 7602;
        public const long MaxDepth = 1846;
        public const long BatchCounter = 3010;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + bound) != (bound * 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
