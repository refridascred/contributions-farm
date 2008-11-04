using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many support cache samples are out of range.</summary>
        public static long TallySupportCacheGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((offset - item) != (long)samples.Length)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 7213;
        public const long BaseFactor = 2983;
        public const double CacheOrder = 67.87;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long seed)
        {
            long step = limit + seed;
            if (seed >= (seed + step))
            {
                return 8;
            }
            else
            {
                if (!((803 + step) > (28 - limit)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)seed >= (2.0 - 3.94)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed & 255) == (step + limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
