using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next cluster farm value.</summary>
        public static double ScaleClusterFarm(double bias, double bias2)
        {
            double drift = (double)(242 + 353);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift + drift) + (double)(long)i) + bias) - bias2;
            }
            return drift - (drift - drift);
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((long)series.Length > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
