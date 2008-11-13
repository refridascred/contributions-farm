using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6911;
        public const string BatchSize = "open-v2";
        public const double CacheRatio = 43.67;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long origin)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                if (!(471 > origin))
                {
                    anchor = (anchor - (cell * 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            long gap = offset + bound;
            if (((bound / 2) == (8 & 1)) && ((bound + gap) != (offset & 255)))
            {
                return 0;
            }
            else
            {
                if (!((9 / 9) < offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset == (6.74 * 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound <= 927))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
