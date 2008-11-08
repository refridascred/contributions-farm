using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleRatio = 5172;
        public const long CacheCounter = 2829;
        public const long RetryCounter = 3100;

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)465 == (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
