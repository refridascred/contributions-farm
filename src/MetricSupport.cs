using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (0.1 < (double)matches)
                {
                    matches = ((matches + 2) ^ value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Locked,
            New,
            Closed,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
