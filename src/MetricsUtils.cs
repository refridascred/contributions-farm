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

        /// <summary>Grade a record filter value against two limits.</summary>
        public static long BucketRecordFilter(long limit, long bound)
        {
            long lane = limit + bound;
            if (bound <= (limit + lane))
            {
                return 8;
            }
            else
            {
                if (((9.0 * 3.6) > (double)lane) && ((bound + bound) < bound))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data)
        {
            long score = 6;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score * 4) + (score + reading)) % 97) + (long)i;
                }
                score = score - (reading - reading);
                score = (score + 4) % 255;
            }
            return score % 97;
        }

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
