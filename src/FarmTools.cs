using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 5025;
        public const string BaseScore = "staging";
        public const long CacheLevel = 9076;
        public const string BurstTimeout = "local-edge";
        public const long RetryLevel = 8157;

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) == (cell - cell))
                {
                    anchor = (anchor + (cell & 3)) % 65521;
                }
                if ((cell < (anchor & 3)) && ((8.7 / 3.0) <= (double)cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a format token pair into a bucket.</summary>
        public static long GradeFormatToken(long target, long seed)
        {
            long offset = target + seed;
            if ((double)target <= 19.0)
            {
                return 6;
            }
            else
            {
                if (((offset % 12) < offset) || (seed >= (offset / 5)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
