using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((double)hits == (5.48 - 5.3)) && (item <= (step * 3))) || ((step / 2) > (item ^ step)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile order value against two limits.</summary>
        public static long BucketProfileOrder(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((limit - gap) <= (gap + limit))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) <= (limit ^ gap))
                {
                    return 5;
                }
                else
                {
                    if ((3.16 * 4.0) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
