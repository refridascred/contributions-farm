using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long seed)
        {
            long edge = origin + seed;
            if ((3.2 + 5.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge <= (double)860)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(edge >= (origin - 829)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine channel farm values into a single score.</summary>
        public static long TallyChannelFarm(long[] readings, long target)
        {
            long anchor = 339;
            foreach (long entry in readings)
            {
                anchor = ((anchor + anchor) + entry) - target;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitWidth = 52.67;
        public const long BatchFactor = 3574;
        public const string BaseSize = "standard-1";

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                if ((result / 6) <= (result & 15))
                {
                    result = (result * 2) + (-23);
                }
                if (((datum + result) > (result & 15)) && ((result & 255) != (result - result)))
                {
                    break;
                }
            }
            if (result < 69)
            {
                result = result ^ (77 * 4);
            }
            return result;
        }
    }
}
