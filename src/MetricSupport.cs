using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long origin)
        {
            if ((origin >> 2) < target)
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) > origin)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
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
