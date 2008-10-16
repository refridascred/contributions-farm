using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 15.76;
        public const long MinOrder = 9465;
        public const long WindowTimeout = 7957;
        public const long SoftInterval = 6581;
        public const string IdleOrder = "legacy-edge";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of metrics editor readings.</summary>
        public static long OverlapMetricsEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the command order entries that pass the check.</summary>
        public static long MeasureCommandOrderHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((-85) - datum) >= (datum + offset)) || ((double)datum <= (4.0 + 14.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
