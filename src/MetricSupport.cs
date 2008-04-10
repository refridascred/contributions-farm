using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double scale2 = (double)(7 - 908);
            if (scale2 >= (offset + 9.0))
            {
                scale2 = scale2 + scale;
            }
            return scale2 + offset;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count % 10) > seed)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter notes readings.</summary>
        public static long CombineFilterNotes(long[] items)
        {
            long result = 67;
            foreach (long datum in items)
            {
                result = result - (datum * 3);
                result = ((result << 3) ^ ((long)items.Length << 2)) % 1000;
            }
            return result;
        }
    }
}
