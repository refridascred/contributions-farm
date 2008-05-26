using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits >= (14.0 / 9.0))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two graph notes measurements.</summary>
        public static double BlendGraphNotes(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - 13.0;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool CheckWindowBatchBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
