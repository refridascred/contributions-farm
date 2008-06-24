using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series, long seed)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = (mix ^ (item - item)) - seed;
                mix = (mix * 4) + 135;
            }
            return mix % 1000;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long step, long limit)
        {
            long edge = step - limit;
            if ((8 - 1) < (edge >> 4))
            {
                return 4;
            }
            else
            {
                if (!((3 + limit) < (step + step)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
