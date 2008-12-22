using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Derive the next stats buffer value from a seed.</summary>
        public static long RollStatsBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (-3)) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length > floor)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
