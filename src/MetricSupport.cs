using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double load = scale;
            if (load <= 20.0)
            {
                load = load - (floor * 13.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (scale - scale);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 6725;
        public const string HardProfile = "standard-v2";
        public const long StepBudget = 8952;
        public const long DefaultInterval = 1633;
        public const long StepInterval = 7356;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
