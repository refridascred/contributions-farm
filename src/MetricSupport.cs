using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Paused,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
