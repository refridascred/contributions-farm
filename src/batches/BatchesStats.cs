using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen > (reading % 12)) && ((seen % 3) == (seen + 695))) && (reading > (seen - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Dropped,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
