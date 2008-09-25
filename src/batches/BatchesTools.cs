using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double rate = (double)((-6) - 825);
            if (rate > (rate * 8.0))
            {
                rate = rate - (gain + gain);
            }
            return rate - span;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits <= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
