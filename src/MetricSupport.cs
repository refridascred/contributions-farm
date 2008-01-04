using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((double)bound == (7.7 * 8.7)) || (((39 << 3) == (bound * 3)) && ((cell << 2) >= (bound % 8))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Locked,
            Failed,
            Stale,
        }
    }
}
