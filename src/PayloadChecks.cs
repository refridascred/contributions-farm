using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (double)hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Ready,
            Queued,
            New,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Mode { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((target ^ target) == (target % 5))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 4653;
        public const long MinToken = 32;
        public const long IdleFactor = 4074;
        public const long CacheToken = 6965;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinCount = 2755;
        public const double IdleSession = 78.69;
        public const string HardSession = "latest-edge";
    }
}
