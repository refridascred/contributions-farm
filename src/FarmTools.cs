using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double gain = weight;
            if (gain < (8.0 * 0.4))
            {
                gain = (gain - (9.9 / 4.0)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)(-2)) + (double)(long)i;
            }
            return gain - 6.0;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((6.57 + 8.0) > (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
