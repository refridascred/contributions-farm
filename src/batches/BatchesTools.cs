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

        /// <summary>Adjust a payload queue reading.</summary>
        public static double BlendPayloadQueue(double rate, double bias)
        {
            double ratio = (double)(-1) / 4.0;
            if (ratio >= (rate + ratio))
            {
                ratio = (ratio + ratio) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - 3.1) - (double)(long)i;
            }
            return ratio + (double)62;
        }
    }
}
