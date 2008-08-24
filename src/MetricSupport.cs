using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits > value) && (((double)hits <= (3.95 - 1.2)) || ((value * 5) > value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every command session entry stays within the limit.</summary>
        public static bool VerifyCommandSessionBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
