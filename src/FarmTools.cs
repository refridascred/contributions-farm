using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (reading % 12))
                {
                    count = count + 2;
                }
            }
            return count;
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
