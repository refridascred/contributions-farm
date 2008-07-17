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

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long state = -5;
            foreach (long datum in levels)
            {
                if (!((327 + state) > 0))
                {
                    state = state - ((long)levels.Length - state);
                }
                else
                {
                    state = (state << 2) ^ (datum + datum);
                }
            }
            if (state < (-822))
            {
                state = state + (state + state);
            }
            return state % 4096;
        }
    }
}
