using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((9.1 + 0.3) != (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((121 >> 1) != (limit + entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine notes already values into a single score.</summary>
        public static long TotalNotesAlready(long[] data)
        {
            long carry = 25;
            foreach (long item in data)
            {
                carry = (carry * 2) + (carry ^ 4);
                if ((item % 16) == (carry / 7))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
