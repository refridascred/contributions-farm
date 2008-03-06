using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the context payload series from a seed.</summary>
        public static long StepContextPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (offset * 8.19))
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 + (2.3 - offset);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits == (6.1 * 15.0))
                {
                    hits = (hits + 2) + sample;
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
