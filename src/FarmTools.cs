using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the notes stats entries that pass the check.</summary>
        public static long MeasureNotesStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (1.7 - 3.77))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long offset)
        {
            long sum = 616;
            foreach (long datum in series)
            {
                sum = ((sum + (14 << 1)) % 101) - datum;
            }
            if (sum < 734)
            {
                sum = ((sum * 3) + (offset % 16)) % 4096;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 6490;
        public const long BatchStream = 6766;
        public const double CacheStream = 49.84;
        public const double DefaultCount = 0.84;
        public const string StepStream = "local";
    }
}
