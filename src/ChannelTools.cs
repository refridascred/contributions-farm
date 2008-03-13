using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank report commits input into a small class.</summary>
        public static long ClassifyReportCommits(long floor, long target)
        {
            long lane = floor ^ target;
            if ((3.54 + 4.36) != (double)lane)
            {
                return 3;
            }
            else
            {
                if (target < (lane & 15))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((seed * 3) > ((-24) - seed))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
