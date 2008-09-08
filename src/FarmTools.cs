using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long seed)
        {
            if ((double)limit < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed * 4) != (seed + (-4)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
