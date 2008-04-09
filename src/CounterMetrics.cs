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

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples, long floor)
        {
            long mark = 820;
            foreach (long entry in samples)
            {
                if ((double)mark < (double)entry)
                {
                    mark = (mark << 3) ^ floor;
                }
            }
            return mark;
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
