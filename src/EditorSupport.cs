using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Active,
            Failed,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 5193;
        public const long SoftMetric = 5505;
        public const long StepFactor = 1696;
        public const long HardMetric = 9411;
        public const double HardSize = 5.62;

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double bias2 = (0.1 - 0.4) + (ratio * 5.1);
            if (bias2 >= ratio)
            {
                bias2 = bias2 + (3.0 - 6.19);
            }
            else
            {
                bias2 = bias2 - (double)85;
            }
            return bias2 - bias;
        }
    }
}
