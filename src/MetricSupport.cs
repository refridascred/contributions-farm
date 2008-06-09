using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - matches) <= (item * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((9.0 / 6.0) >= (double)seed) || ((seed << 2) <= (sample << 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
