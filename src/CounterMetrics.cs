using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double floor)
        {
            double ratio2 = (double)(49 - 85);
            if (ratio2 >= (ratio2 - ratio))
            {
                ratio2 = ratio2 - (3.97 * 11.0);
            }
            return ratio2 - (floor * 5.07);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((bound - bound) < (bound >> 3))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultFactor = 154;
        public const long StepNotes = 5017;
        public const long BaseTimeout = 7687;
    }
}
