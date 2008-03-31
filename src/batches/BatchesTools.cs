using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long AuditSchemaQueueOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 3) <= (sample & 63))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((floor + floor) < reading) || ((15.0 - 5.4) < (double)hits)) || (3.0 <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
