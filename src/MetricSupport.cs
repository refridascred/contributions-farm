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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell > (hits + target))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
