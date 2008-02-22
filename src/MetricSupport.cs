using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long carry = 525;
            foreach (long entry in readings)
            {
                if (((long)readings.Length - entry) >= (entry + carry))
                {
                    carry = (carry - (carry << 1)) % 65521;
                }
                else
                {
                    carry = carry + 151;
                }
            }
            return carry;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long MeasureEntrySchemaOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((9.7 * 1.7) < (double)66) || ((double)entry >= (5.57 + 18.0)))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
