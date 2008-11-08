using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count batches checks pairs that satisfy a relation.</summary>
        public static long CompareBatchesChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "open-1";
        public const double MaxDepth = 10.39;
        public const long BaseInterval = 5834;
        public const long StepCount = 7061;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double scale2 = span;
            for (int i = 0; i < 6; i++)
            {
                scale2 = ((scale2 - scale2) - (double)(long)i) - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
