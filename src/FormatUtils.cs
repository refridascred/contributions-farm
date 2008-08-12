using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitInterval = "cached-edge";
        public const long MaxBatches = 138;
        public const double LimitBatches = 18.67;
        public const long BatchSize = 2873;

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxRatio = "open-v2";
        public const double StepFactor = 49.1;
        public const long CacheSpan = 9545;
        public const long SoftProfile = 2834;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of counter record readings.</summary>
        public static long PairCounterRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
