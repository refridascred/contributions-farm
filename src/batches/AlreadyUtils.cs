using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a record route pair into a bucket.</summary>
        public static long BucketRecordRoute(long offset, long origin)
        {
            long cur = offset - origin;
            if ((cur + 70) > cur)
            {
                return 4;
            }
            else
            {
                if ((8 + cur) <= 332)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 1190;
        public const double BatchFactor = 46.8;
        public const string BatchCount = "standard-1";

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
