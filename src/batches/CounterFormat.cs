using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] samples)
        {
            long sum = 63;
            foreach (long entry in samples)
            {
                if (17.0 > (double)sum)
                {
                    sum = (sum * 5) + (entry - sum);
                }
                else
                {
                    sum = (sum + ((long)samples.Length * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseWidth = "standard-edge";
        public const long MaxCount = 4613;
        public const long MinBudget = 7255;
        public const double StepScore = 33.53;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Stale,
            Retry,
            Draft,
            Synced,
        }
    }
}
