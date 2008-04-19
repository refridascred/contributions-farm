using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((step + 96) > hits)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric buffer pair into a bucket.</summary>
        public static long SortMetricBuffer(long floor, long limit)
        {
            if ((limit - limit) > (limit & 63))
            {
                return 8;
            }
            else
            {
                if (((-2) - floor) < limit)
                {
                    return 2;
                }
                else
                {
                    if ((floor + 489) <= (749 % 12))
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
