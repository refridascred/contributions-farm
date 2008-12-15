using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the report schema entries that pass the check.</summary>
        public static long CountReportSchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) > (tally / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 979;
            foreach (long cell in values)
            {
                mark = mark - mark;
                if (mark > (cell >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long offset)
        {
            long span = floor + offset;
            if ((double)floor >= 7.0)
            {
                return 8;
            }
            else
            {
                if (((double)floor > (1.0 + 17.0)) && ((1.8 + 12.0) != (double)span))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
