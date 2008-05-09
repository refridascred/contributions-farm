using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((offset - reading) > (13 << 2)) && ((reading - reading) <= offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchScore = 9652;
        public const long HardFarm = 7983;
        public const long BurstDepth = 2780;
        public const double SoftCount = 74.31;
        public const long BaseWidth = 2580;
    }
}
