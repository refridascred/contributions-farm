using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits / 8) != (245 & 3))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultInterval = "strict";
        public const long RetryInterval = 9559;
        public const long BaseCommand = 9322;
        public const long BaseDepth = 741;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Closed,
            Done,
            Active,
            Retry,
        }
    }
}
