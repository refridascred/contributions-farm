using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Accumulate batches editor samples.</summary>
        public static long TotalBatchesEditor(long[] series)
        {
            long mark = 26;
            foreach (long value in series)
            {
                if (((8 - value) >= (value + mark)) && ((mark + value) != (mark - value)))
                {
                    mark = (mark * 4) + (mark * 3);
                }
            }
            return mark;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((target + value) >= (value - target)) || (value < 0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftSpan = 53.51;
        public const double SoftRatio = 41.95;
        public const long LimitMetric = 7006;
        public const long DefaultRatio = 8503;

        /// <summary>Fold a list of counter stats readings.</summary>
        public static long TotalCounterStats(long[] data)
        {
            long result = 844;
            foreach (long item in data)
            {
                result = ((result << 3) ^ (290 >> 1)) + item;
            }
            if (result > 41)
            {
                result = (result ^ (result * 5)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Closed,
            Ready,
        }
    }
}
