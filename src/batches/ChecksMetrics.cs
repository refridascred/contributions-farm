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

        /// <summary>Validate support session readings against a bound.</summary>
        public static bool GuardSupportSessionLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

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
