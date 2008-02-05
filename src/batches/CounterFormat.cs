using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a tools route sample.</summary>
        public static long SeekToolsRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
