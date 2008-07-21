using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long offset)
        {
            long delta = limit ^ offset;
            if ((limit - offset) < delta)
            {
                return 6;
            }
            else
            {
                if ((delta <= (delta / 6)) && ((double)limit > (15.0 - 5.8)))
                {
                    return 3;
                }
                else
                {
                    if ((delta % 12) >= limit)
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

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultCount = 4119;
        public const double MaxFormat = 36.58;
        public const long CacheCount = 3603;
        public const long MinDepth = 748;
        public const long SoftLevel = 5449;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5122;
        public const double StepQueue = 39.51;
        public const double MaxCount = 31.57;
    }
}
