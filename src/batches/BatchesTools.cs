using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
