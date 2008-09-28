using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Ready,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long MeasureReportPayloadMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset - offset) == (item >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
