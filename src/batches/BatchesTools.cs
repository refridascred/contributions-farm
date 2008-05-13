using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (floor <= (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long sum = 470;
            foreach (long sample in readings)
            {
                sum = (((sum - (long)readings.Length) % 1000) + sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((9.0 / 5.0) <= (double)cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
