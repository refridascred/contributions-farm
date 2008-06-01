using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheCount = 4383;
        public const string HardToken = "primary-edge";
        public const string SoftRatio = "standard";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if (origin <= (offset % 16))
            {
                return 2;
            }
            else
            {
                if (59 > (18 - offset))
                {
                    return 6;
                }
                else
                {
                    if (228 > (offset & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((offset + (long)series.Length) >= sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
