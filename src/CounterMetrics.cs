using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor - (origin ^ 297)) % 4096) ^ value;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Done,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + 6) > datum)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long mark = 373;
            foreach (long entry in values)
            {
                mark = ((mark * 3) + (entry + mark)) % 65521;
            }
            if (mark > 1)
            {
                mark = mark + (offset & 3);
            }
            return mark % 1000;
        }
    }
}
