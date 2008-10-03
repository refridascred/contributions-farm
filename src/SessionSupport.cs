using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry githubfarm readings against a rule.</summary>
        public static long TallyEntryGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length / 8) <= (sample >> 1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Stale,
            Draft,
            New,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
