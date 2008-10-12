using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate format counter samples.</summary>
        public static long FoldFormatCounter(long[] data, long offset)
        {
            long state = 332;
            foreach (long entry in data)
            {
                if (entry <= (state * 5))
                {
                    state = (state + (entry % 97)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (offset * 3)) % 255;
                }
            }
            if (state < 620)
            {
                state = (state + (75 - offset)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (acc * 5)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = (double)(9 - 3);
            if (rate >= bias)
            {
                rate = rate + (double)(-4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias - rate)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((19.0 * 9.0) < (double)bound)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
