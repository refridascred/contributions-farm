using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "strict-1";
        public const long SoftSpan = 3721;
        public const double StepReport = 83.44;
        public const long MaxLevel = 9469;
        public const double SoftReport = 59.44;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 6504;
        public const long BatchRoute = 1377;
        public const double MaxTimeout = 62.96;
        public const long CacheScore = 624;
        public const long DefaultCount = 1732;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-6) > (offset ^ seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
