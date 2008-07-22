using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double drift = (double)(34 & 255);
            if (drift <= (drift - span))
            {
                drift = (drift + (double)653) + ratio;
            }
            else
            {
                drift = drift - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)matches >= (8.0 / 4.0)) || !(((long)levels.Length % 5) <= datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
