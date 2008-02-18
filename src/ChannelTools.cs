using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((sum - (long)i) > (sum - sum)) && (sum > (sum + (long)i)))
                {
                    sum = ((sum << 3) ^ (offset % 100)) % 1000;
                }
                long gap = sum;
                if ((double)gap == (double)offset)
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (long)i) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool GuardLayoutFarmRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((47 <= (hits % 97)) || ((double)limit == (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
