using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long AuditFilterChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen > (seen * 3))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Failed,
            Active,
            Paused,
            Locked,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long sum = 42;
            foreach (long datum in readings)
            {
                sum = ((sum * 2) + datum) % 1000;
            }
            return sum;
        }
    }
}
