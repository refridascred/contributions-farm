using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 <= 4.33)
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 + (weight2 / 5.0);
            }
            return weight2 + (double)592;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples, long seed)
        {
            long state = 809;
            foreach (long value in samples)
            {
                if (((long)samples.Length >> 5) == (seed + seed))
                {
                    state = (state * 5) + (state + value);
                }
                else
                {
                    state = (state - (value / 5)) % 65521;
                }
            }
            if (state < 768)
            {
                state = (state + state) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits <= sample) || !(hits < sample))
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
    }
}
