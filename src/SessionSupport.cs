using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long total = 358;
            foreach (long datum in samples)
            {
                if ((total - 70) > bound)
                {
                    total = (total ^ (total << 1)) ^ datum;
                }
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry - hits) < hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm buffer series from a seed.</summary>
        public static long RollFarmBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state + limit) % 65521;
                state = (state << 2) ^ limit;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
