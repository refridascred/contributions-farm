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

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!(mark > ((long)i + 718)))
                {
                    mark = mark + (mark & 3);
                }
                long span = mark;
                if ((551 >> 3) > (span / 6))
                {
                    long next = (6 - mark) / 8;
                    span = (span + next) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
