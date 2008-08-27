using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metrics tools counter forward.</summary>
        public static long SeriesMetricsTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Synced,
            Stale,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Stale,
            Active,
        }
    }
}
