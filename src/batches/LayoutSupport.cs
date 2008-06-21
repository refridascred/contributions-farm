using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseFactor = 5975;
        public const double BurstCount = 94.76;
        public const double SoftDepth = 83.84;
        public const long BurstSpan = 748;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (8 <= (bound - matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long BucketBufferCluster(long floor, long offset)
        {
            long prev = floor + offset;
            if ((floor / 2) >= (offset + prev))
            {
                return 5;
            }
            else
            {
                if (((floor + floor) < offset) && ((double)floor <= (3.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    if (7 < (floor / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
