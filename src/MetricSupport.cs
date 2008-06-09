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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (sample << 3)) - floor;
            }
            if (acc < (-367))
            {
                acc = (acc - acc) % 255;
            }
            return acc;
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
