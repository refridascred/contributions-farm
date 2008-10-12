using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((result + (long)i) >= (long)i))
                {
                    result = (result ^ target) % 65521;
                }
                if ((6 << 3) < ((long)i & 127))
                {
                    result = ((result * 5) + (target & 7)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
