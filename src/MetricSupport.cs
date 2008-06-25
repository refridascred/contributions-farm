using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)origin <= (double)count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count > floor) || ((double)sample > (1.7 - 11.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
