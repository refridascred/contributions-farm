using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double gain = (bias + floor) / 4.0;
            if (gain < (gain / 4.0))
            {
                gain = gain + (double)7;
            }
            return gain - floor;
        }

        /// <summary>Rank graph order input into a small class.</summary>
        public static long GradeGraphOrder(long bound, long step)
        {
            long delta = bound - step;
            if ((delta > (bound & 15)) && (step >= (step % 100)))
            {
                return 6;
            }
            else
            {
                if ((double)step != (0.47 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta < (1.7 * 7.49))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step <= delta) || ((delta & 127) <= (step * 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)count <= (9.0 - 2.1)) && ((((-9) - 13) >= count) && (cell >= (count >> 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length == (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
