using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long offset)
        {
            long state = 66;
            foreach (long entry in readings)
            {
                if (state >= (state / 3))
                {
                    state = ((((state << 2) ^ ((-560) % 2)) % 255) ^ entry) - offset;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long AuditFilterQueueMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (0 + hits))
                {
                    hits = ((hits + 2) - item) - bound;
                }
            }
            return hits;
        }
    }
}
