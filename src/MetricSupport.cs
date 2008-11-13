using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first editor order entry that matches the target.</summary>
        public static long LookupEditorOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double floor)
        {
            double load = floor + floor;
            if (load > (double)4)
            {
                load = (load - floor) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long bound)
        {
            long mark = 30;
            foreach (long datum in values)
            {
                if (((mark - datum) == (datum & 127)) || (mark < (datum + (-373))))
                {
                    mark = (mark - datum) + bound;
                }
            }
            return mark;
        }
    }
}
