using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Adjust a cache checks reading.</summary>
        public static double AdjustCacheChecks(double gain, double floor)
        {
            double bias = (double)150 + (double)(-42);
            if (bias < (double)2)
            {
                bias = (bias - (bias / 4.0)) - gain;
            }
            else
            {
                bias = bias + (2.73 / 4.0);
            }
            return bias - (floor - 1.9);
        }

        /// <summary>Match up contributi metrics samples.</summary>
        public static long OverlapContributiMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
