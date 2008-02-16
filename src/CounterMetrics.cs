using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxTimeout = 5160;
        public const string SoftTimeout = "alpha-1";
        public const long IdleSize = 2080;
        public const string MaxMetrics = "standard-edge";
        public const string LimitMetrics = "stable-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3723;
        public const long LimitLevel = 6058;
        public const string BaseFactor = "standard";
        public const string MaxScore = "standard-v2";

        /// <summary>Count metrics record pairs that satisfy a relation.</summary>
        public static long CompareMetricsRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) > 406)
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
