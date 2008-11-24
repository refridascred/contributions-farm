using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((58 - hits) < entry) || ((hits << 1) <= (hits & 63)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length + sample) <= (sample + count)) || (count >= (count - sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
