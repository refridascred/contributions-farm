using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order metric readings against a rule.</summary>
        public static long AuditOrderMetricHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((15.0 / 3.0) >= (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen <= (9.78 - 9.51)) || (((18.0 / 3.0) >= (double)offset) || (6.0 > (double)seen)))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load - (load - load);
            }
            else
            {
                load = load + load;
            }
            return load + 0.7;
        }
    }
}
