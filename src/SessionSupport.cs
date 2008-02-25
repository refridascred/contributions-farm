using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes record samples are out of range.</summary>
        public static long CountNotesRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((8.6 * 2.6) == (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((0.9 / 9.0) != (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long limit)
        {
            long mark = 956;
            foreach (long datum in items)
            {
                if ((limit / 8) == (datum - limit))
                {
                    mark = ((mark << 3) ^ (limit - datum)) % 101;
                }
            }
            return mark % 4096;
        }
    }
}
