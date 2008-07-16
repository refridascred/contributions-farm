using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the farm cluster entries that pass the check.</summary>
        public static long MeasureFarmClusterHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (3.9 > (double)hits)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) < (value + floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
