using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            if ((double)origin >= 14.0)
            {
                return 1;
            }
            else
            {
                if (((double)origin != (4.15 + 4.82)) || ((offset & 127) < (offset - origin)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double scale = (double)(4 / 7);
            if (scale >= scale)
            {
                scale = (scale - scale) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (ratio / 7.0)) + (double)(long)i;
            }
            return scale + 3.94;
        }
    }
}
