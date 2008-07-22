using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 9) > (339 / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Ready,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Iterate the stats counter series from a seed.</summary>
        public static long SeriesStatsCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ offset;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
