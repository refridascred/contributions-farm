using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of graph stream readings.</summary>
        public static long FoldGraphStream(long[] readings, long bound)
        {
            long carry = 83;
            foreach (long sample in readings)
            {
                carry = (carry + (sample - carry)) % 97;
                if (!((bound ^ carry) >= (carry * 5)))
                {
                    break;
                }
            }
            return carry % 4096;
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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + (long)samples.Length) > (76 / 4))
                {
                    seen = ((seen + 1) ^ value) - offset;
                }
            }
            return seen;
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
