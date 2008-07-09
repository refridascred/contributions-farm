using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double gain = (double)(3 - 82);
            if (gain >= (5.5 + floor))
            {
                gain = gain + (0.88 + 3.86);
            }
            return gain - bias;
        }

        /// <summary>Measure how many order layout samples are out of range.</summary>
        public static long TallyOrderLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value <= hits) || ((6 & 63) != (hits * 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
