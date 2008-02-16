using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long offset, long seed)
        {
            long next = offset - seed;
            if ((seed > (seed % 12)) || ((offset % 8) <= (offset - seed)))
            {
                return 4;
            }
            else
            {
                if (((offset >> 2) < 394) || (offset >= (seed + next)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < 5.29)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
