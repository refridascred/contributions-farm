using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Synced,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long MeasureFormatNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!!((value << 2) <= (value + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
