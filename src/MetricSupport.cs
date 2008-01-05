using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (872 + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Stale,
            Idle,
            New,
        }
    }
}
