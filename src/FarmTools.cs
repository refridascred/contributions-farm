using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((647 - hits) < (59 + origin)) || (((-12) >> 4) > (hits + hits)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (offset * 9.0)) - (double)(long)i;
            }
            return mean + (offset - 20.0);
        }

        /// <summary>Scale a checks stream figure with a bias.</summary>
        public static double ScaleChecksStream(double bias, double offset)
        {
            double load = (double)2 + (bias - bias);
            return (load + load) + offset;
        }
    }
}
