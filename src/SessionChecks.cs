using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 1) < (seen + 617))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every buffer githubfarm entry stays within the limit.</summary>
        public static bool ValidateBufferGithubfarmLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
