using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next contributi entry value from a seed.</summary>
        public static long DeriveContributiEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9641;
        public const long DefaultGraph = 2764;
        public const long StepLevel = 6573;
        public const long MaxDepth = 1914;
        public const long WindowLevel = 9557;
    }
}
