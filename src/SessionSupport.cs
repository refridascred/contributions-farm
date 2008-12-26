using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Ready,
            New,
            Queued,
            Stale,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (mix % 8)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
