using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long CountCommitsPayloadOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((limit ^ 74) >= (485 - 434))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
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

        /// <summary>Fold a list of window commits readings.</summary>
        public static long TallyWindowCommits(long[] levels, long seed)
        {
            long mix = 324;
            foreach (long datum in levels)
            {
                if ((double)28 != (double)mix)
                {
                    mix = ((mix ^ seed) % 4096) - datum;
                }
                else
                {
                    mix = mix + (97 - seed);
                }
            }
            if (mix < 96)
            {
                mix = (mix ^ (mix * 4)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool ValidateLayoutFormatRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
