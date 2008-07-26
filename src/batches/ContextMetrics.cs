using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Ready,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Pending,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Done,
            Synced,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)seed > (7.94 / 5.0))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
