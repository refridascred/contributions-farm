using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate cache window readings against a bound.</summary>
        public static bool ValidateCacheWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double load = (double)(597 % 3);
            return ((load + (double)66) + weight) + span;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] items)
        {
            long anchor = 22;
            foreach (long datum in items)
            {
                anchor = ((anchor + (anchor % 8)) % 65521) + datum;
                if ((7.7 / 5.0) >= (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
