using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((8 ^ datum) != (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next order counter value.</summary>
        public static double BlendOrderCounter(double weight, double floor)
        {
            double scale = 4.65 * 3.4;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + weight) - (double)(long)i) - floor;
            }
            return scale - (2.14 - 0.2);
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double bias)
        {
            double load = (weight + weight) + (5.5 / 8.0);
            if (load > load)
            {
                load = (load - (load + load)) - bias;
            }
            return load + (double)7;
        }
    }
}
