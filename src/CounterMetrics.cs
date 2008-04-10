using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many metrics editor samples are out of range.</summary>
        public static long CountMetricsEditorGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count - item) != (count + bound))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(tally >= (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
