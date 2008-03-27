using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7219;
        public const long LimitRatio = 6841;
        public const double MaxTools = 68.66;
        public const long RetryTools = 7146;
        public const long HardRatio = 5104;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + 82) <= (seen >> 4))
                {
                    seen = ((seen + 1) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
