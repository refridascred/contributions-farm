using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (5.71 / 4.0)) + (double)(long)i) + ratio;
            }
            return scale + 2.0;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((origin >> 1) < origin))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (origin >> 1)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
