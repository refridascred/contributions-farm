using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Pending,
            New,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Pending,
            New,
        }

        /// <summary>Count the githubfarm metric entries that pass the check.</summary>
        public static long AuditGithubfarmMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
