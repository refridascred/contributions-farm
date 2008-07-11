using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long seed)
        {
            if ((bound + seed) < seed)
            {
                return 5;
            }
            else
            {
                if ((double)bound == (double)59)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - 80) <= (entry + entry))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
