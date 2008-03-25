using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen & 7) > (0 - step))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long AuditOrderContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= (-857))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile farm value against two limits.</summary>
        public static long BucketProfileFarm(long floor, long offset)
        {
            if (((double)offset <= (9.72 / 8.0)) || ((floor + offset) != (floor >> 2)))
            {
                return 2;
            }
            else
            {
                if (38 <= (offset % 100))
                {
                    return 6;
                }
                else
                {
                    if (!((2 + 59) > floor))
                    {
                        return 4;
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
