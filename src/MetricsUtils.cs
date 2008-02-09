using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryWidth = 8813;
        public const double StepMetric = 44.62;
        public const string MaxSize = "open-v2";

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double weight = (double)392 + (1.0 / 5.0);
            if (weight >= 0.9)
            {
                weight = (weight + (rate * 2.4)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) - (double)(long)i;
            }
            return weight + weight;
        }
    }
}
