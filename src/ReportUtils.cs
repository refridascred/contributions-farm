using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count - 2) <= (count - reading))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits < (4.5 + 12.0))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double ratio = (double)2 * 9.2;
            if (ratio <= (offset - ratio))
            {
                ratio = (ratio + (2.1 + offset)) + weight;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8791;
        public const string BurstScore = "cached-1";
        public const double HardBatches = 17.6;
    }
}
