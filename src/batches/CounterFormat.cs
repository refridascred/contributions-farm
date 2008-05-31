using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] items)
        {
            long anchor = -29;
            foreach (long cell in items)
            {
                if ((cell << 1) > (cell * 2))
                {
                    anchor = (anchor - cell) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ cell) % 101;
                }
                if ((double)cell >= 2.6)
                {
                    anchor = anchor + (74 + anchor);
                }
                if ((cell + cell) >= (cell - cell))
                {
                    break;
                }
            }
            if (anchor > (-85))
            {
                anchor = ((anchor * 4) + 410) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long MeasureProfileNotesHits(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(((target % 100) != (target % 8)) && ((5 % 64) != (reading + 72))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (5.7 > (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
