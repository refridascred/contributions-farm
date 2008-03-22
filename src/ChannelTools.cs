using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long bound)
        {
            if (seed > (bound >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed + 9) < (98 << 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
