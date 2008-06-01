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

        /// <summary>Accumulate editor route samples.</summary>
        public static long TallyEditorRoute(long[] values, long limit)
        {
            long score = 911;
            foreach (long datum in values)
            {
                if (96 >= (score & 15))
                {
                    score = ((score * 4) + (limit + (-1))) % 101;
                }
                if (((datum ^ 786) >= (datum >> 5)) || ((score & 127) <= (datum - limit)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
