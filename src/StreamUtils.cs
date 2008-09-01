using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 6643;
        public const long MaxSession = 3917;
        public const long BatchSession = 472;
        public const double LimitDepth = 54.59;

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitScore = "stable-v2";
        public const long BatchChecks = 5064;
        public const string IdleChecks = "local-v2";
        public const long BurstCount = 2099;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultScore = 80;
        public const string BatchWidth = "standard-edge";
        public const long MaxNotes = 900;
        public const double StepNotes = 81.49;

        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long AuditAlreadyContributiHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) > (matches - cell))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
