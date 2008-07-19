using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            long prev = limit + bound;
            if (((double)limit != (double)540) || ((limit >> 1) >= 858))
            {
                return 0;
            }
            else
            {
                if (limit <= (limit / 2))
                {
                    return 6;
                }
                else
                {
                    if ((7 + bound) == (bound / 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= (prev - bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long MeasureChecksEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + item) < (3 + 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.2 / 4.0) > (double)hits)
                {
                    hits = ((hits + 1) - cell) - seed;
                }
            }
            return hits;
        }
    }
}
