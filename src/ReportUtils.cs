using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate account graph readings against a bound.</summary>
        public static bool ValidateAccountGraphBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 6252;
        public const long MaxBudget = 56;
        public const long CacheInterval = 6435;
        public const double LimitFactor = 49.24;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Synced,
            New,
            Failed,
        }
    }
}
