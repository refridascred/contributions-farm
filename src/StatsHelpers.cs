using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + step) >= (hits >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
                mix = mix + (25 + mix);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long CombineBatchWindow(long[] data, long target)
        {
            long state = 90;
            foreach (long reading in data)
            {
                state = state ^ reading;
            }
            if (state > 533)
            {
                state = ((state << 3) ^ (target >> 4)) % 4096;
            }
            return state;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double bias = 3.0 - floor;
            if (bias < floor)
            {
                bias = (bias + (floor / 6.0)) - ratio;
            }
            return bias - bias;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (bias - 9.6))
            {
                ratio2 = ratio2 - (ratio / 8.0);
            }
            else
            {
                ratio2 = ratio2 + (double)32;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 - (double)8;
        }
    }
}
