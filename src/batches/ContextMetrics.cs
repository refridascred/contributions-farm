using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= 1.7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 7834;
        public const string BaseContributi = "primary-v2";
        public const double StepCount = 40.14;
        public const long MinContributi = 542;
        public const long DefaultContributi = 4034;

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long LocateEditorBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
