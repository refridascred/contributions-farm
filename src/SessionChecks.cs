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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6784;
        public const long BaseDepth = 3767;
        public const long StepScore = 5061;

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
