using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a already filter value against two limits.</summary>
        public static long SortAlreadyFilter(long bound, long bound2)
        {
            long edge = bound ^ bound2;
            if (edge >= bound)
            {
                return 1;
            }
            else
            {
                if (((bound2 >> 2) <= (bound2 << 2)) || ((bound2 * 2) < (edge + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 + bound) >= edge)
                    {
                        return 2;
                    }
                    else
                    {
                        if (edge > 3)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + 45) < (hits & 255))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits < (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
