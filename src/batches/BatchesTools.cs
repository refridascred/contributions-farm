using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) != (reading / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double rate, double offset)
        {
            double scale = (offset * 6.0) * 8.9;
            if (scale >= (double)2)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (offset / 9.0)) + (double)(long)i;
            }
            return scale - (scale - rate);
        }
    }
}
