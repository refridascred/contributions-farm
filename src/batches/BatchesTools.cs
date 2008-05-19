using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long seed)
        {
            long mix = 924;
            foreach (long cell in readings)
            {
                mix = ((mix + 473) + cell) + seed;
            }
            if (mix > 807)
            {
                mix = (mix ^ 0) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            if ((40 < seed) || ((double)seed != (0.27 * 2.1)))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed / 9))
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
}
