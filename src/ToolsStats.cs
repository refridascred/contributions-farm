using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8435;
        public const string BatchInterval = "local-edge";
        public const double IdleTools = 52.83;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long OverlapClusterRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
