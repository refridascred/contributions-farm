using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long bound)
        {
            if (bound < (bound + target))
            {
                return 4;
            }
            else
            {
                if ((970 + bound) < 95)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowSize = 55.31;
        public const double DefaultLayout = 56.86;
        public const double BatchWidth = 93.11;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((floor + count) >= (floor + floor))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
