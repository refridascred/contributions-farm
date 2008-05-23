using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((count + item) > (item - count)) && ((1.45 * 9.55) > (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits >= (target + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
