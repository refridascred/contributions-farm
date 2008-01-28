using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((item - 57) >= (item * 2)) || !(matches > limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long MeasureProfileSchemaOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)target <= (7.93 * 4.0))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
