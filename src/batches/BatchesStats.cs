using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank payload checks input into a small class.</summary>
        public static long GradePayloadChecks(long limit, long offset)
        {
            if ((offset / 7) != (290 % 5))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) > (offset / 6))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every support cluster entry stays within the limit.</summary>
        public static bool GuardSupportClusterRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record support value from a seed.</summary>
        public static long StepRecordSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - floor) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
