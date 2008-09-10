using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Queued,
            New,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 3) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
