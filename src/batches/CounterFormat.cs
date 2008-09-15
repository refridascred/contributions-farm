using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics editor readings against a rule.</summary>
        public static long TallyMetricsEditorMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((step << 2) > seen)
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count % 16) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((4 ^ value) != (value ^ floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
