using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Failed,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "staging-v2";
        public const string MinBuffer = "staging";
        public const long BatchBuffer = 4978;

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double SmoothChecksMetrics(double ratio, double bias)
        {
            double gain = (double)468 + (bias - ratio);
            if (gain > bias)
            {
                gain = gain + 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)164) + (double)(long)i;
            }
            return gain + (ratio / 3.0);
        }
    }
}
