using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long target)
        {
            long bound = step + target;
            if ((1.0 - 9.56) < (double)step)
            {
                return 4;
            }
            else
            {
                if (!((bound * 5) > (3 + 719)))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 127) != (target * 4))
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

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Ready,
            Pending,
            Closed,
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
