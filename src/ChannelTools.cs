using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a channel layout pair into a bucket.</summary>
        public static long RankChannelLayout(long bound, long floor)
        {
            long prev = bound + floor;
            if ((double)floor > 6.69)
            {
                return 8;
            }
            else
            {
                if (77 <= (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev != (double)floor) && ((bound << 2) <= (830 - prev)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardLevel = 5141;
        public const long DefaultMetric = 8039;
        public const string LimitWidth = "fallback-edge";
        public const long BatchScore = 2173;
        public const long CacheMetric = 5004;

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long MeasureStreamSessionHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((floor % 5) <= (seen ^ seen)))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
