using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches >> 1) <= (limit + limit))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series)
        {
            long mark = 461;
            foreach (long value in series)
            {
                if ((23 / 5) > (value / 8))
                {
                    mark = (mark * 4) + (value - mark);
                }
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
