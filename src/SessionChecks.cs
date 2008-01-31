using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (double)seen)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 127) > 3)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
