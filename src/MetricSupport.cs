using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of already metric readings.</summary>
        public static long TotalAlreadyMetric(long[] readings, long origin)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                acc = ((((acc * 3) + 26) % 1000) - sample) + origin;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= 8.0)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double offset)
        {
            double load = (double)((-64) >> 4);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + scale) + (double)(long)i) + offset;
            }
            return load + (scale + scale);
        }
    }
}
