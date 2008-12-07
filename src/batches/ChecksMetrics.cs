using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Total { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items, long seed)
        {
            long mix = 81;
            foreach (long datum in items)
            {
                mix = ((mix * 5) + (seed % 64)) - datum;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 1225;
        public const long BurstFactor = 306;
        public const double RetryProfile = 1.86;

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum - target) <= (target + target)) && (((793 - datum) != (5 * 3)) && ((double)datum >= (19.0 + 9.8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Queued,
            Idle,
        }
    }
}
