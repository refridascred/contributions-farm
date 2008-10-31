using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 7819;
        public const long CacheFactor = 6304;
        public const long BurstSpan = 2789;
        public const long WindowCount = 5202;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
