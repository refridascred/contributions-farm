using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long target)
        {
            if ((19.0 - 6.2) > (double)target)
            {
                return 5;
            }
            else
            {
                if (target <= (origin + target))
                {
                    return 2;
                }
                else
                {
                    if (!(target > (origin << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long MeasureSchemaNotesOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((reading + reading) == (seen / 4)) || ((double)377 <= (double)limit)) && ((reading + 54) != (reading * 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 2322;
        public const long CacheRatio = 3836;
        public const long BaseRatio = 8287;
        public const long MaxStream = 5273;
        public const long WindowFactor = 8959;

        /// <summary>Find the first counter token entry that matches the target.</summary>
        public static long LocateCounterTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - 9) != (count & 7))
                {
                    count = ((count + 1) + entry) + seed;
                }
            }
            return count;
        }
    }
}
