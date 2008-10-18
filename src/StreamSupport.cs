using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many order filter samples are out of range.</summary>
        public static long CountOrderFilterMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((offset - offset) > (6 & 7)) || (((double)hits >= (4.5 * 7.83)) || ((double)entry >= (1.0 + 9.6))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate queue support readings against a bound.</summary>
        public static bool ValidateQueueSupportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
