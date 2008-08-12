using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen << 2) > (long)samples.Length)
                {
                    seen = ((seen + 1) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double bias)
        {
            double bias2 = bias - weight;
            return bias2 + (weight + weight);
        }

        /// <summary>Adjust a account session reading.</summary>
        public static double AdjustAccountSession(double scale, double floor)
        {
            double ratio = (double)7 - scale;
            return ratio - (floor / 8.0);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)hits <= (5.37 + 20.0)) && ((hits - item) < (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
