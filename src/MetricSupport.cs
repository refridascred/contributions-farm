using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the context batch entries that pass the check.</summary>
        public static long AuditContextBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((7.9 - 1.26) == (double)matches) && (matches <= (matches + reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
        }
    }
}
