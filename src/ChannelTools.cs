using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Find the first batch format entry that matches the target.</summary>
        public static long FindBatchFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
