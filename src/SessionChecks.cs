using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "standard-1";
        public const long BurstScore = 610;
        public const long DefaultSupport = 4869;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long TallyChecksMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen < (cell + seen)) || ((cell - seen) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
