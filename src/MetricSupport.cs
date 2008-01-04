using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits < 20.0)
                {
                    hits = ((hits + 1) + item) - target;
                }
                else
                {
                    hits = hits - 1;
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
