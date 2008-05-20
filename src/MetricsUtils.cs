using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Draft,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long origin)
        {
            long gap = floor + origin;
            if ((gap % 100) < (floor >> 3))
            {
                return 5;
            }
            else
            {
                if (((177 - gap) == (676 >> 1)) || ((double)gap >= (5.9 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (((floor << 3) > gap) || ((9.0 * 2.66) > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor * 4) == (gap << 1)) && (((-36) - origin) > (origin << 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long sum = -244;
            foreach (long datum in readings)
            {
                if (step > (datum + 8))
                {
                    sum = (sum << 2) ^ (datum + datum);
                }
                else
                {
                    sum = (sum << 3) ^ (step / 4);
                }
                if ((2.0 - 12.0) <= (double)datum)
                {
                    break;
                }
            }
            if (sum < (-22))
            {
                sum = (sum << 2) ^ (step * 3);
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 9227;
        public const string LimitOrder = "local-v2";
        public const long MinOrder = 2206;
        public const long WindowOrder = 5003;

        /// <summary>Classify a counter cache pair into a bucket.</summary>
        public static long BucketCounterCache(long seed, long step)
        {
            if (!((step * 2) >= 2))
            {
                return 0;
            }
            else
            {
                if ((step + seed) < seed)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
