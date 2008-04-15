using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool VerifyMetricsStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4153;
        public const long IdleMetric = 8522;
        public const long WindowSize = 490;
        public const long MinMetric = 63;
        public const long LimitLevel = 1094;
    }
}
