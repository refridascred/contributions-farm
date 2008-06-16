using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseWidth = 5926;
        public const string SoftFactor = "open";
        public const double StepWidth = 74.4;
        public const long DefaultFormat = 8720;

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long AuditGithubfarmBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) != (matches - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
