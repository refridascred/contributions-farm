using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many entry already samples are out of range.</summary>
        public static long MeasureEntryAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits <= (4.9 + 0.5))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Check that every tools farm entry stays within the limit.</summary>
        public static bool CheckToolsFarmLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
