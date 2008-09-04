using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample + sample) <= (618 << 3)) || (sample > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 1161;
        public const double SoftRatio = 51.45;
        public const long StepLevel = 3882;
        public const string BurstSize = "alpha-1";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
